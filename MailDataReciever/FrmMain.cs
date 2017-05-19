using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;
using System.Text.RegularExpressions;
using System.IO;
using MySql.Data.MySqlClient;

namespace MailDataReciever {
    public partial class FrmMain : Form {

        private SshClient iSSHClient = null;
        private SftpClient iSFtp = null;
        private ForwardedPortLocal iSSHTunnel = null;
        private MySqlConnection MysqlConn = null;

        bool Connected = false;

        public FrmMain() {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            iSFtp = new SftpClient(txtSFtpIP.Text, Convert.ToInt32(numUpDownSFtpPort.Value), txtSFtpUsername.Text, txtSFtpPassword.Text);

            try {
                iSFtp.Connect();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                iSFtp.Dispose();
                iSFtp = null;

                FlashState();
                return;
            }
            
            if(checkBoxUseSSH.Checked) {
                // Setup SSH connection.
                iSSHClient = new SshClient(txtSSHTunnelIP.Text, Convert.ToInt32(numUpDownSSHTunnelPort.Value), txtSSHTunnelUsername.Text, txtSSHTunnelPassword.Text);

                try {
                    iSSHClient.Connect();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    iSSHClient.Dispose();
                    iSSHClient = null;

                    iSFtp.Disconnect();
                    iSFtp.Dispose();
                    iSFtp = null;

                    FlashState();
                    return;
                }

                // Setup port forwarding.
                iSSHTunnel = new ForwardedPortLocal("127.0.0.1", 0, txtDBIP.Text, Convert.ToUInt32(numUpDownDBPort.Value));
                iSSHClient.AddForwardedPort(iSSHTunnel);

                try {
                    iSSHTunnel.Start();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    iSSHClient.RemoveForwardedPort(iSSHTunnel);

                    iSSHTunnel.Dispose();
                    iSSHTunnel = null;

                    iSSHClient.Disconnect();
                    iSSHClient.Dispose();
                    iSSHClient = null;

                    iSFtp.Disconnect();
                    iSFtp.Dispose();
                    iSFtp = null;

                    FlashState();
                    return;
                }
            } // End if(checkBoxUseSSH.Checked)

            MySqlConnectionStringBuilder connStrBuilder = new MySqlConnectionStringBuilder();
            connStrBuilder.Server = checkBoxUseSSH.Checked ? iSSHTunnel.BoundHost : txtDBIP.Text;
            connStrBuilder.Port = checkBoxUseSSH.Checked ? iSSHTunnel.BoundPort : Convert.ToUInt32(numUpDownDBPort.Value);
            connStrBuilder.UserID = txtDBUsername.Text;
            connStrBuilder.Password = txtDBPassword.Text;

            MysqlConn = new MySqlConnection(connStrBuilder.GetConnectionString(true));

            try {
                MysqlConn.Open();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MysqlConn.Dispose();
                MysqlConn = null;

                if(checkBoxUseSSH.Checked) {
                    iSSHTunnel.Stop();

                    iSSHClient.RemoveForwardedPort(iSSHTunnel);

                    iSSHTunnel.Dispose();
                    iSSHTunnel = null;

                    iSSHClient.Disconnect();
                    iSSHClient.Dispose();
                    iSSHClient = null;
                }

                iSFtp.Disconnect();
                iSFtp.Dispose();
                iSFtp = null;

                FlashState();
                return;
            }

            // Connect Done.
            Connected = true;
            FlashState();
        }

        private void btnDownloadFile_Click(object sender, EventArgs e) {
            string emlPath = listViewMails.SelectedItems[0].SubItems[2].Text;
            string emlFileName = emlPath.Split('/').Last();
            emlPath = "/home/maildata/" + emlPath;

            if(iSFtp.Exists(emlPath)) {
                FileStream fs = new FileStream(txtFilePath.Text + "\\" + emlFileName + ".eml", FileMode.Create, FileAccess.Write);
                iSFtp.DownloadFile(emlPath, fs);
                fs.Close();
            } else {
                MessageBox.Show("File does not exist.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            if (!Connected) return;

            MysqlConn.Close();
            MysqlConn.Dispose();
            MysqlConn = null;

            if(checkBoxUseSSH.Checked) {
                iSSHTunnel.Stop();

                iSSHClient.RemoveForwardedPort(iSSHTunnel);

                iSSHTunnel.Dispose();
                iSSHTunnel = null;

                iSSHClient.Disconnect();
                iSSHClient.Dispose();
                iSSHClient = null;
            }

            iSFtp.Disconnect();
            iSFtp.Dispose();
            iSFtp = null;

            //Disconnect Done
            Connected = false;
            FlashState();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            //FlashState();
            txtFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            
            bool ConfigExists = File.Exists("config.ini");
            FileStream ConfigFile = new FileStream("config.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            if(!ConfigExists) {
                string DefaultConfig =
@"[SFTP]
IP=
Port=22
Username=
Password=

[Database]
IP=
Port=3306
Username=
Password=

[SSH Tunnel]
Use=false
IP=
Port=22
Username=
Password= 
";
                ConfigFile.Position = 0;
                ConfigFile.Write(Encoding.Default.GetBytes(DefaultConfig), 0, Encoding.Default.GetByteCount(DefaultConfig));
                ConfigFile.Close();
                FlashState();
                return;
            }

            StreamReader fsReader = null;
            try {
                ConfigFile.Position = 0;
                fsReader = new StreamReader(ConfigFile);

                string StrBuffer;

                while ((StrBuffer = fsReader.ReadLine()) != "[SFTP]");
                // Read sftp server IP.
                txtSFtpIP.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("IP=", "")
                    )
                );
                // Read sftp server port.
                numUpDownSFtpPort.Value = Convert.ToDecimal(
                    fsReader.ReadLine().Replace(" ", "").Replace("Port=", "")
                );
                // Read sftp server username.
                txtSFtpUsername.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Username=", "")
                    )
                );
                // Read sftp server password.
                txtSFtpPassword.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Password=", "")
                    )
                );


                while ((StrBuffer = fsReader.ReadLine()) != "[Database]");
                // Read database IP.
                txtDBIP.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("IP=", "")
                    )
                );
                // Read database port.
                numUpDownDBPort.Value = Convert.ToDecimal(
                    fsReader.ReadLine().Replace(" ", "").Replace("Port=", "")
                );
                // Read database username.
                txtDBUsername.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Username=", "")
                    )
                );
                // Read database password.
                txtDBPassword.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Password=", "")
                    )
                );


                while ((StrBuffer = fsReader.ReadLine()) != "[SSH Tunnel]");
                // Read SSH Tunnel State.
                checkBoxUseSSH.Checked = fsReader.ReadLine().Replace(" ", "").Replace("Use=", "") == "true";
                // Read SSH Tunnel IP
                txtSSHTunnelIP.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("IP=", "")
                    )
                );
                // Read SSH Tunnel port.
                numUpDownSSHTunnelPort.Value = Convert.ToDecimal(
                    fsReader.ReadLine().Replace(" ", "").Replace("Port=", "")
                );
                // Read SSH Tunnel username.
                txtSSHTunnelUsername.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Username=", "")
                    )
                );
                // Read SSH Tunnel password.
                txtSSHTunnelPassword.Text = Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        fsReader.ReadLine().Replace(" ", "").Replace("Password=", "")
                    )
                );
            } catch {
                MessageBox.Show("File config.ini is damaged. Only part of settings will be loaded.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (fsReader != null) fsReader.Close();
            ConfigFile.Close();
            FlashState();
        }

        private void FlashState() {
            if(Connected) {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                groupBoxMailDataServer.Enabled = false;
                groupBoxMysqlServer.Enabled = false;

                listViewMails.Enabled = true;
                groupBoxMailAddress.Enabled = true;
                groupBoxDownload.Enabled = true;
            } else {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                groupBoxMailDataServer.Enabled = true;
                groupBoxMysqlServer.Enabled = true;

                listViewMails.Enabled = false;
                groupBoxMailAddress.Enabled = false;
                groupBoxDownload.Enabled = false;
            }

            checkBoxUseSSH_CheckedChanged(null, null);
        }

        private void checkBoxUseSSH_CheckedChanged(object sender, EventArgs e) {
            if(checkBoxUseSSH.Checked) {
                txtSSHTunnelIP.Enabled = true;
                numUpDownSSHTunnelPort.Enabled = true;
                txtSSHTunnelUsername.Enabled = true;
                txtSSHTunnelPassword.Enabled = true;
            } else {
                txtSSHTunnelIP.Enabled = false;
                numUpDownSSHTunnelPort.Enabled = false;
                txtSSHTunnelUsername.Enabled = false;
                txtSSHTunnelPassword.Enabled = false;
            }
        }

        bool IsValidEmail(string srcString) {
            return Regex.IsMatch(srcString, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            if(SelectFolder.ShowDialog() == DialogResult.OK) {
                txtFilePath.Text = SelectFolder.SelectedPath;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            btnDisconnect_Click(null, null);

            FileStream ConfigFile = new FileStream("config.ini", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(ConfigFile);
            sw.WriteLine("[SFTP]");
            sw.WriteLine("IP=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSFtpIP.Text)));
            sw.WriteLine("Port=" + numUpDownSFtpPort.Value.ToString());
            sw.WriteLine("Username=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSFtpUsername.Text)));
            sw.WriteLine("Password=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSFtpPassword.Text)));
            sw.WriteLine();
            sw.WriteLine("[Database]");
            sw.WriteLine("IP=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtDBIP.Text)));
            sw.WriteLine("Port=" + numUpDownDBPort.Value.ToString());
            sw.WriteLine("Username=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtDBUsername.Text)));
            sw.WriteLine("Password=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtDBPassword.Text)));
            sw.WriteLine();
            sw.WriteLine("[SSH Tunnel]");
            sw.WriteLine("Use=" + (checkBoxUseSSH.Checked ? "true" : "false"));
            sw.WriteLine("IP=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSSHTunnelIP.Text)));
            sw.WriteLine("Port=" + numUpDownSSHTunnelPort.Value.ToString());
            sw.WriteLine("Username=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSSHTunnelUsername.Text)));
            sw.WriteLine("Password=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSSHTunnelPassword.Text)));
            sw.Flush();
            sw.Close();
            ConfigFile.Close();
        }

        private void btnListMails_Click(object sender, EventArgs e) {
            if (!Connected) return;

            if(IsValidEmail(txtMailAddress.Text) == false) {
                MessageBox.Show("Not a valid mail address.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tmp = Regex.Replace(txtMailAddress.Text, @"\W", "_");
            MySqlCommand sqlCmd = new MySqlCommand("select id, emlpath, title from mailcenter.mc_mails_p_" + tmp + " order by id;", MysqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();

            listViewMails.Items.Clear();
            string[] element = new string[3];
            while (reader.Read()) {
                element[0] = reader["id"].ToString();
                element[1] = reader["title"].ToString();
                element[2] = reader["emlpath"].ToString();
                ListViewItem item = new ListViewItem(element);
                listViewMails.Items.Add(item);
            }

            reader.Close();
            listViewMails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    }
}