namespace MailDataReciever {
    partial class FrmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMailDataServerIP = new System.Windows.Forms.TextBox();
            this.groupBoxMailDataServer = new System.Windows.Forms.GroupBox();
            this.numUpDownSFtpPort = new System.Windows.Forms.NumericUpDown();
            this.labelSFtpPort = new System.Windows.Forms.Label();
            this.labelSFtpPassword = new System.Windows.Forms.Label();
            this.txtMailDataServerPassword = new System.Windows.Forms.TextBox();
            this.txtMailDataServerUsername = new System.Windows.Forms.TextBox();
            this.labelSFtpUsername = new System.Windows.Forms.Label();
            this.labelSFtpIP = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBoxMysqlServer = new System.Windows.Forms.GroupBox();
            this.numUpDownSSHTunnelPort = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDBPort = new System.Windows.Forms.NumericUpDown();
            this.labelSSHTunnelPort = new System.Windows.Forms.Label();
            this.labelSSHTunnelPassword = new System.Windows.Forms.Label();
            this.txtSSHTunnelPassword = new System.Windows.Forms.TextBox();
            this.txtSSHTunnelUsername = new System.Windows.Forms.TextBox();
            this.labelSSHTunnelUsername = new System.Windows.Forms.Label();
            this.labelSSHTunnelIP = new System.Windows.Forms.Label();
            this.txtSSHTunnelIP = new System.Windows.Forms.TextBox();
            this.labelDBPort = new System.Windows.Forms.Label();
            this.checkBoxUseSSH = new System.Windows.Forms.CheckBox();
            this.labelDBPassword = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.txtDBUsername = new System.Windows.Forms.TextBox();
            this.labelDBUsername = new System.Windows.Forms.Label();
            this.labelDBIP = new System.Windows.Forms.Label();
            this.txtDBIP = new System.Windows.Forms.TextBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnListMails = new System.Windows.Forms.Button();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.groupBoxMailAddress = new System.Windows.Forms.GroupBox();
            this.listViewMails = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMailDataServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSFtpPort)).BeginInit();
            this.groupBoxMysqlServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSSHTunnelPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDBPort)).BeginInit();
            this.groupBoxDownload.SuspendLayout();
            this.groupBoxMailAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 33);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMailDataServerIP
            // 
            this.txtMailDataServerIP.Location = new System.Drawing.Point(80, 18);
            this.txtMailDataServerIP.Name = "txtMailDataServerIP";
            this.txtMailDataServerIP.Size = new System.Drawing.Size(163, 21);
            this.txtMailDataServerIP.TabIndex = 1;
            // 
            // groupBoxMailDataServer
            // 
            this.groupBoxMailDataServer.Controls.Add(this.numUpDownSFtpPort);
            this.groupBoxMailDataServer.Controls.Add(this.labelSFtpPort);
            this.groupBoxMailDataServer.Controls.Add(this.labelSFtpPassword);
            this.groupBoxMailDataServer.Controls.Add(this.txtMailDataServerPassword);
            this.groupBoxMailDataServer.Controls.Add(this.txtMailDataServerUsername);
            this.groupBoxMailDataServer.Controls.Add(this.labelSFtpUsername);
            this.groupBoxMailDataServer.Controls.Add(this.labelSFtpIP);
            this.groupBoxMailDataServer.Controls.Add(this.txtMailDataServerIP);
            this.groupBoxMailDataServer.Location = new System.Drawing.Point(12, 50);
            this.groupBoxMailDataServer.Name = "groupBoxMailDataServer";
            this.groupBoxMailDataServer.Size = new System.Drawing.Size(260, 133);
            this.groupBoxMailDataServer.TabIndex = 2;
            this.groupBoxMailDataServer.TabStop = false;
            this.groupBoxMailDataServer.Text = "MailData Server SFtp Info";
            // 
            // numUpDownSFtpPort
            // 
            this.numUpDownSFtpPort.Location = new System.Drawing.Point(80, 46);
            this.numUpDownSFtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUpDownSFtpPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownSFtpPort.Name = "numUpDownSFtpPort";
            this.numUpDownSFtpPort.Size = new System.Drawing.Size(80, 21);
            this.numUpDownSFtpPort.TabIndex = 2;
            this.numUpDownSFtpPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // labelSFtpPort
            // 
            this.labelSFtpPort.AutoSize = true;
            this.labelSFtpPort.Location = new System.Drawing.Point(39, 48);
            this.labelSFtpPort.Name = "labelSFtpPort";
            this.labelSFtpPort.Size = new System.Drawing.Size(35, 12);
            this.labelSFtpPort.TabIndex = 7;
            this.labelSFtpPort.Text = "Port:";
            // 
            // labelSFtpPassword
            // 
            this.labelSFtpPassword.AutoSize = true;
            this.labelSFtpPassword.Location = new System.Drawing.Point(18, 104);
            this.labelSFtpPassword.Name = "labelSFtpPassword";
            this.labelSFtpPassword.Size = new System.Drawing.Size(59, 12);
            this.labelSFtpPassword.TabIndex = 6;
            this.labelSFtpPassword.Text = "Password:";
            // 
            // txtMailDataServerPassword
            // 
            this.txtMailDataServerPassword.Location = new System.Drawing.Point(80, 101);
            this.txtMailDataServerPassword.Name = "txtMailDataServerPassword";
            this.txtMailDataServerPassword.PasswordChar = '*';
            this.txtMailDataServerPassword.Size = new System.Drawing.Size(163, 21);
            this.txtMailDataServerPassword.TabIndex = 4;
            // 
            // txtMailDataServerUsername
            // 
            this.txtMailDataServerUsername.Location = new System.Drawing.Point(80, 74);
            this.txtMailDataServerUsername.Name = "txtMailDataServerUsername";
            this.txtMailDataServerUsername.Size = new System.Drawing.Size(163, 21);
            this.txtMailDataServerUsername.TabIndex = 3;
            this.txtMailDataServerUsername.Text = "root";
            // 
            // labelSFtpUsername
            // 
            this.labelSFtpUsername.AutoSize = true;
            this.labelSFtpUsername.Location = new System.Drawing.Point(18, 77);
            this.labelSFtpUsername.Name = "labelSFtpUsername";
            this.labelSFtpUsername.Size = new System.Drawing.Size(59, 12);
            this.labelSFtpUsername.TabIndex = 3;
            this.labelSFtpUsername.Text = "Username:";
            // 
            // labelSFtpIP
            // 
            this.labelSFtpIP.AutoSize = true;
            this.labelSFtpIP.Location = new System.Drawing.Point(54, 21);
            this.labelSFtpIP.Name = "labelSFtpIP";
            this.labelSFtpIP.Size = new System.Drawing.Size(23, 12);
            this.labelSFtpIP.TabIndex = 2;
            this.labelSFtpIP.Text = "IP:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(145, 11);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(127, 33);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBoxMysqlServer
            // 
            this.groupBoxMysqlServer.Controls.Add(this.numUpDownSSHTunnelPort);
            this.groupBoxMysqlServer.Controls.Add(this.numUpDownDBPort);
            this.groupBoxMysqlServer.Controls.Add(this.labelSSHTunnelPort);
            this.groupBoxMysqlServer.Controls.Add(this.labelSSHTunnelPassword);
            this.groupBoxMysqlServer.Controls.Add(this.txtSSHTunnelPassword);
            this.groupBoxMysqlServer.Controls.Add(this.txtSSHTunnelUsername);
            this.groupBoxMysqlServer.Controls.Add(this.labelSSHTunnelUsername);
            this.groupBoxMysqlServer.Controls.Add(this.labelSSHTunnelIP);
            this.groupBoxMysqlServer.Controls.Add(this.txtSSHTunnelIP);
            this.groupBoxMysqlServer.Controls.Add(this.labelDBPort);
            this.groupBoxMysqlServer.Controls.Add(this.checkBoxUseSSH);
            this.groupBoxMysqlServer.Controls.Add(this.labelDBPassword);
            this.groupBoxMysqlServer.Controls.Add(this.txtDBPassword);
            this.groupBoxMysqlServer.Controls.Add(this.txtDBUsername);
            this.groupBoxMysqlServer.Controls.Add(this.labelDBUsername);
            this.groupBoxMysqlServer.Controls.Add(this.labelDBIP);
            this.groupBoxMysqlServer.Controls.Add(this.txtDBIP);
            this.groupBoxMysqlServer.Location = new System.Drawing.Point(278, 12);
            this.groupBoxMysqlServer.Name = "groupBoxMysqlServer";
            this.groupBoxMysqlServer.Size = new System.Drawing.Size(573, 171);
            this.groupBoxMysqlServer.TabIndex = 4;
            this.groupBoxMysqlServer.TabStop = false;
            this.groupBoxMysqlServer.Text = "MailData Database Info";
            // 
            // numUpDownSSHTunnelPort
            // 
            this.numUpDownSSHTunnelPort.Location = new System.Drawing.Point(363, 74);
            this.numUpDownSSHTunnelPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUpDownSSHTunnelPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownSSHTunnelPort.Name = "numUpDownSSHTunnelPort";
            this.numUpDownSSHTunnelPort.Size = new System.Drawing.Size(80, 21);
            this.numUpDownSSHTunnelPort.TabIndex = 11;
            this.numUpDownSSHTunnelPort.TabStop = false;
            this.numUpDownSSHTunnelPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // numUpDownDBPort
            // 
            this.numUpDownDBPort.Location = new System.Drawing.Point(80, 74);
            this.numUpDownDBPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUpDownDBPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownDBPort.Name = "numUpDownDBPort";
            this.numUpDownDBPort.Size = new System.Drawing.Size(78, 21);
            this.numUpDownDBPort.TabIndex = 6;
            this.numUpDownDBPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // labelSSHTunnelPort
            // 
            this.labelSSHTunnelPort.AutoSize = true;
            this.labelSSHTunnelPort.Location = new System.Drawing.Point(322, 76);
            this.labelSSHTunnelPort.Name = "labelSSHTunnelPort";
            this.labelSSHTunnelPort.Size = new System.Drawing.Size(35, 12);
            this.labelSSHTunnelPort.TabIndex = 22;
            this.labelSSHTunnelPort.Text = "Port:";
            // 
            // labelSSHTunnelPassword
            // 
            this.labelSSHTunnelPassword.AutoSize = true;
            this.labelSSHTunnelPassword.Location = new System.Drawing.Point(298, 131);
            this.labelSSHTunnelPassword.Name = "labelSSHTunnelPassword";
            this.labelSSHTunnelPassword.Size = new System.Drawing.Size(59, 12);
            this.labelSSHTunnelPassword.TabIndex = 21;
            this.labelSSHTunnelPassword.Text = "Password:";
            // 
            // txtSSHTunnelPassword
            // 
            this.txtSSHTunnelPassword.Location = new System.Drawing.Point(363, 127);
            this.txtSSHTunnelPassword.Name = "txtSSHTunnelPassword";
            this.txtSSHTunnelPassword.PasswordChar = '*';
            this.txtSSHTunnelPassword.Size = new System.Drawing.Size(148, 21);
            this.txtSSHTunnelPassword.TabIndex = 13;
            this.txtSSHTunnelPassword.TabStop = false;
            // 
            // txtSSHTunnelUsername
            // 
            this.txtSSHTunnelUsername.Location = new System.Drawing.Point(363, 100);
            this.txtSSHTunnelUsername.Name = "txtSSHTunnelUsername";
            this.txtSSHTunnelUsername.Size = new System.Drawing.Size(148, 21);
            this.txtSSHTunnelUsername.TabIndex = 12;
            this.txtSSHTunnelUsername.TabStop = false;
            this.txtSSHTunnelUsername.Text = "root";
            // 
            // labelSSHTunnelUsername
            // 
            this.labelSSHTunnelUsername.AutoSize = true;
            this.labelSSHTunnelUsername.Location = new System.Drawing.Point(298, 103);
            this.labelSSHTunnelUsername.Name = "labelSSHTunnelUsername";
            this.labelSSHTunnelUsername.Size = new System.Drawing.Size(59, 12);
            this.labelSSHTunnelUsername.TabIndex = 18;
            this.labelSSHTunnelUsername.Text = "Username:";
            // 
            // labelSSHTunnelIP
            // 
            this.labelSSHTunnelIP.AutoSize = true;
            this.labelSSHTunnelIP.Location = new System.Drawing.Point(334, 50);
            this.labelSSHTunnelIP.Name = "labelSSHTunnelIP";
            this.labelSSHTunnelIP.Size = new System.Drawing.Size(23, 12);
            this.labelSSHTunnelIP.TabIndex = 17;
            this.labelSSHTunnelIP.Text = "IP:";
            // 
            // txtSSHTunnelIP
            // 
            this.txtSSHTunnelIP.Location = new System.Drawing.Point(363, 46);
            this.txtSSHTunnelIP.Name = "txtSSHTunnelIP";
            this.txtSSHTunnelIP.Size = new System.Drawing.Size(148, 21);
            this.txtSSHTunnelIP.TabIndex = 10;
            this.txtSSHTunnelIP.TabStop = false;
            // 
            // labelDBPort
            // 
            this.labelDBPort.AutoSize = true;
            this.labelDBPort.Location = new System.Drawing.Point(39, 76);
            this.labelDBPort.Name = "labelDBPort";
            this.labelDBPort.Size = new System.Drawing.Size(35, 12);
            this.labelDBPort.TabIndex = 15;
            this.labelDBPort.Text = "Port:";
            // 
            // checkBoxUseSSH
            // 
            this.checkBoxUseSSH.AutoSize = true;
            this.checkBoxUseSSH.Location = new System.Drawing.Point(300, 24);
            this.checkBoxUseSSH.Name = "checkBoxUseSSH";
            this.checkBoxUseSSH.Size = new System.Drawing.Size(108, 16);
            this.checkBoxUseSSH.TabIndex = 9;
            this.checkBoxUseSSH.Text = "Use SSH Tunnel";
            this.checkBoxUseSSH.UseVisualStyleBackColor = true;
            this.checkBoxUseSSH.CheckedChanged += new System.EventHandler(this.checkBoxUseSSH_CheckedChanged);
            // 
            // labelDBPassword
            // 
            this.labelDBPassword.AutoSize = true;
            this.labelDBPassword.Location = new System.Drawing.Point(15, 129);
            this.labelDBPassword.Name = "labelDBPassword";
            this.labelDBPassword.Size = new System.Drawing.Size(59, 12);
            this.labelDBPassword.TabIndex = 12;
            this.labelDBPassword.Text = "Password:";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(80, 127);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(163, 21);
            this.txtDBPassword.TabIndex = 8;
            // 
            // txtDBUsername
            // 
            this.txtDBUsername.Location = new System.Drawing.Point(80, 100);
            this.txtDBUsername.Name = "txtDBUsername";
            this.txtDBUsername.Size = new System.Drawing.Size(163, 21);
            this.txtDBUsername.TabIndex = 7;
            // 
            // labelDBUsername
            // 
            this.labelDBUsername.AutoSize = true;
            this.labelDBUsername.Location = new System.Drawing.Point(18, 103);
            this.labelDBUsername.Name = "labelDBUsername";
            this.labelDBUsername.Size = new System.Drawing.Size(59, 12);
            this.labelDBUsername.TabIndex = 9;
            this.labelDBUsername.Text = "Username:";
            // 
            // labelDBIP
            // 
            this.labelDBIP.AutoSize = true;
            this.labelDBIP.Location = new System.Drawing.Point(54, 49);
            this.labelDBIP.Name = "labelDBIP";
            this.labelDBIP.Size = new System.Drawing.Size(23, 12);
            this.labelDBIP.TabIndex = 8;
            this.labelDBIP.Text = "IP:";
            // 
            // txtDBIP
            // 
            this.txtDBIP.Location = new System.Drawing.Point(80, 46);
            this.txtDBIP.Name = "txtDBIP";
            this.txtDBIP.Size = new System.Drawing.Size(163, 21);
            this.txtDBIP.TabIndex = 5;
            this.txtDBIP.Text = "localhost";
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.Controls.Add(this.btnSelectFolder);
            this.groupBoxDownload.Controls.Add(this.txtFilePath);
            this.groupBoxDownload.Controls.Add(this.btnDownloadFile);
            this.groupBoxDownload.Location = new System.Drawing.Point(591, 288);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(260, 91);
            this.groupBoxDownload.TabIndex = 6;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Save File To";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(200, 20);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(54, 23);
            this.btnSelectFolder.TabIndex = 9;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(6, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(188, 21);
            this.txtFilePath.TabIndex = 8;
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Location = new System.Drawing.Point(6, 49);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(248, 36);
            this.btnDownloadFile.TabIndex = 6;
            this.btnDownloadFile.Text = "Download";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // btnListMails
            // 
            this.btnListMails.Location = new System.Drawing.Point(6, 47);
            this.btnListMails.Name = "btnListMails";
            this.btnListMails.Size = new System.Drawing.Size(248, 40);
            this.btnListMails.TabIndex = 8;
            this.btnListMails.Text = "List Mails";
            this.btnListMails.UseVisualStyleBackColor = true;
            this.btnListMails.Click += new System.EventHandler(this.btnListMails_Click);
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(6, 20);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(248, 21);
            this.txtMailAddress.TabIndex = 9;
            // 
            // groupBoxMailAddress
            // 
            this.groupBoxMailAddress.Controls.Add(this.txtMailAddress);
            this.groupBoxMailAddress.Controls.Add(this.btnListMails);
            this.groupBoxMailAddress.Location = new System.Drawing.Point(591, 189);
            this.groupBoxMailAddress.Name = "groupBoxMailAddress";
            this.groupBoxMailAddress.Size = new System.Drawing.Size(260, 93);
            this.groupBoxMailAddress.TabIndex = 11;
            this.groupBoxMailAddress.TabStop = false;
            this.groupBoxMailAddress.Text = "Mail Address";
            // 
            // listViewMails
            // 
            this.listViewMails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnTitle,
            this.columnPath});
            this.listViewMails.FullRowSelect = true;
            this.listViewMails.GridLines = true;
            this.listViewMails.LabelWrap = false;
            this.listViewMails.Location = new System.Drawing.Point(12, 189);
            this.listViewMails.Name = "listViewMails";
            this.listViewMails.Size = new System.Drawing.Size(573, 375);
            this.listViewMails.TabIndex = 13;
            this.listViewMails.UseCompatibleStateImageBehavior = false;
            this.listViewMails.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            // 
            // columnPath
            // 
            this.columnPath.Text = "Path";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 576);
            this.Controls.Add(this.listViewMails);
            this.Controls.Add(this.groupBoxMailAddress);
            this.Controls.Add(this.groupBoxDownload);
            this.Controls.Add(this.groupBoxMysqlServer);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.groupBoxMailDataServer);
            this.Controls.Add(this.btnConnect);
            this.Name = "FrmMain";
            this.Text = "MailData Receiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxMailDataServer.ResumeLayout(false);
            this.groupBoxMailDataServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSFtpPort)).EndInit();
            this.groupBoxMysqlServer.ResumeLayout(false);
            this.groupBoxMysqlServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSSHTunnelPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDBPort)).EndInit();
            this.groupBoxDownload.ResumeLayout(false);
            this.groupBoxDownload.PerformLayout();
            this.groupBoxMailAddress.ResumeLayout(false);
            this.groupBoxMailAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMailDataServerIP;
        private System.Windows.Forms.GroupBox groupBoxMailDataServer;
        private System.Windows.Forms.Label labelSFtpIP;
        private System.Windows.Forms.Label labelSFtpPassword;
        private System.Windows.Forms.TextBox txtMailDataServerPassword;
        private System.Windows.Forms.TextBox txtMailDataServerUsername;
        private System.Windows.Forms.Label labelSFtpUsername;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBoxMysqlServer;
        private System.Windows.Forms.CheckBox checkBoxUseSSH;
        private System.Windows.Forms.Label labelDBPassword;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.TextBox txtDBUsername;
        private System.Windows.Forms.Label labelDBUsername;
        private System.Windows.Forms.Label labelDBIP;
        private System.Windows.Forms.TextBox txtDBIP;
        private System.Windows.Forms.GroupBox groupBoxDownload;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder;
        private System.Windows.Forms.TextBox txtSSHTunnelIP;
        private System.Windows.Forms.Label labelDBPort;
        private System.Windows.Forms.Label labelSSHTunnelUsername;
        private System.Windows.Forms.Label labelSSHTunnelIP;
        private System.Windows.Forms.Label labelSFtpPort;
        private System.Windows.Forms.Label labelSSHTunnelPassword;
        private System.Windows.Forms.TextBox txtSSHTunnelPassword;
        private System.Windows.Forms.TextBox txtSSHTunnelUsername;
        private System.Windows.Forms.Label labelSSHTunnelPort;
        private System.Windows.Forms.NumericUpDown numUpDownSFtpPort;
        private System.Windows.Forms.NumericUpDown numUpDownSSHTunnelPort;
        private System.Windows.Forms.NumericUpDown numUpDownDBPort;
        private System.Windows.Forms.Button btnListMails;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.GroupBox groupBoxMailAddress;
        private System.Windows.Forms.ListView listViewMails;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnPath;
    }
}

