# MailDataReciever

## 1. What is __MailData__
* __MailData__ is a system used to achieve mails. This system is designed by [Beijing 朗阁 Information Technology Co. Ltd.](http://www.maildata.cn/) whose original name is __Beijing 易信源 Information Technology Co. Ltd.__

* __MailData__ can achieve any specified mails by monitoring network gateways. If a mail passes through the monitored network gateway, no matter it passes in or passes out, __MailData__ will make a copy of the mail and save the copy to a specified host with a name that looks like a UUID string. Of course, to manage those achieved mails conveniently, __MailData__ has a MySQL database to record the information of any achieved mails.

__NOTICE: What described in the next paragraph is not UNIVERSAL.__

* For example, if mary@example1.com sends a mail to john@example2.com on February 10th, 2017, of course `example1` can be equal to `example2`, and this mail passes through the monitored network gateway, __MailData__ will make a copy of the mail and save it to specified host at `/home/maildata/201702/10/` with a name, for example, `"31552c88-14e2-3ba8-a675-536ac1bbadc9"`. But it does not seem that __MailData__ will encrypt the saved file. Actually the saved file is simply just a `eml` file. The partial of the file's absolute path, for example `"201702/10/31552c88-14e2-3ba8-a675-536ac1bbadc9"`, will be saved as a string in a MySQL database at the table `mailcenter.mc_mails_p_mary_example1_com`. If `example1` is equal to `example2`, the table 'mailcenter.mc_mails_p_john_example2_com' is likely to have a similliar record.

## 2. How does the program work.
* As we know how __MailData__ works, what the program does is just:
    1. Connect to the MySQL database.
    2. Query the specified record.
    3. Get the string that contains the partial path of a mail's file.
    4. Build the absolute path string.
    5. Use SFTP to download the corresponding file by passing the absolute path string built in Step 4.
    6. End
