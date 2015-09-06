using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.ComponentModel;
using System.Configuration;
namespace AutekInfo.Common
{//测试
    public sealed class Automail
    {
        static string strHost = ConfigurationManager.AppSettings["MailHost"];
        static string strFrom = ConfigurationManager.AppSettings["MailSender"];
        static string TempMailcc = ConfigurationManager.AppSettings["TempMailcc"];
        static string TempMailto = ConfigurationManager.AppSettings["TempMailto"];
        static bool IsCredentials = bool.Parse(ConfigurationManager.AppSettings["IsCredentials"]);
        static string CredentialsID = ConfigurationManager.AppSettings["CredentialsID"];
        static string IsCredentialsPWD = ConfigurationManager.AppSettings["IsCredentialsPWD"];
        static string MailSenderShow = ConfigurationManager.AppSettings["MailSenderShow"];
        //static string MailSenderShow = ConfigurationManager.AppSettings["MailSenderShow"];
        //static string MailSenderShow = ConfigurationManager.AppSettings["MailSenderShow"];
        static bool istest = bool.Parse(ConfigurationManager.AppSettings["istestmode"]);
        public delegate void sendMailDelegate(string mail_to, string title, string body, string CC, string Priority);
        public delegate void sendErrorDelegate(string body);
        //异步
        public  void AsySendMail(string mail_to, string title, string body, string CC, string Priority)
        {
            sendMailDelegate sendm = new sendMailDelegate(sendMail);
            sendm.BeginInvoke(mail_to, title, body, CC, Priority, null, null);
          //  //Common.LogManager.WriteLog("SendMailLog", mail_to + "：" + "--------------" + title + "：" + CC + "----------[[[[[[[[[[" + body.Substring(0, body.Length>500?500:body.Length) + "]]]]]]]]]]]]]]");
        }
        public void AsysendError(string body)
        {
            sendErrorDelegate sener = new sendErrorDelegate(sendError);
            sener.BeginInvoke(body , null, null);
          //  //Common.LogManager.WriteLog("SysError", body);
        }
        public void SynSendMail(string mail_to, string title, string body, string CC, string Priority)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Host = strHost;
            _smtpClient.UseDefaultCredentials = IsCredentials;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Credentials = new NetworkCredential(CredentialsID, IsCredentialsPWD);
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress(strFrom, MailSenderShow);
            if (istest)
            {
                _mailMessage.To.Add(TempMailto);
            }
            else
            {
                _mailMessage.To.Add(mail_to);
            }
            _mailMessage.Subject = title;
            _mailMessage.Body = body;
            _mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            if (CC != "")
            {
                if (istest)
                {
                    _mailMessage.CC.Add(TempMailcc);
                }
                else 
                {
                    _mailMessage.CC.Add(CC);
                }                
            }
            switch (Priority)
            {
                case "H":
                    _mailMessage.Priority = MailPriority.High;
                    break;
                case "L":
                    _mailMessage.Priority = MailPriority.Low;
                    break;
                default:
                    _mailMessage.Priority = MailPriority.Normal;
                    break;
            }

            _mailMessage.IsBodyHtml = true;
            object userState = _mailMessage;
            _smtpClient.Send(_mailMessage);
           // //Common.LogManager.WriteLog("SendMailLog", mail_to + "：" + "--------------" + title + "：" + CC + "----------[[[[[[[[[[" + body.Substring(0, body.Length > 500 ? 500 : body.Length) + "]]]]]]]]]]]]]]");
        }
        public void SynsendError(string body)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Host = strHost;
            _smtpClient.UseDefaultCredentials = IsCredentials;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Credentials = new NetworkCredential(CredentialsID, IsCredentialsPWD);
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress(strFrom, MailSenderShow);
            _mailMessage.To.Add(TempMailto);
            _mailMessage.Subject = "程序异常！";
            _mailMessage.Body = body;
            _mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            _mailMessage.IsBodyHtml = true;
            object userState = _mailMessage;
            _smtpClient.Send(_mailMessage);
           // //Common.LogManager.WriteLog("SysError", body);
        }
        public  void sendMail(string mail_to, string title, string body, string CC, string Priority)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Host = strHost;
            _smtpClient.UseDefaultCredentials = IsCredentials;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Credentials = new NetworkCredential(CredentialsID, IsCredentialsPWD);
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress(strFrom, MailSenderShow);
            if (istest)
            {
                _mailMessage.To.Add(TempMailto);
            }
            else 
            {
                _mailMessage.To.Add(mail_to);
            }
            _mailMessage.Subject = title;
            _mailMessage.Body = body;
            _mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            if (CC != "")
            {
                if (istest)
                {
                    //_mailMessage.Bcc.Add(TempMailcc);
                    _mailMessage.CC.Add(TempMailcc);
                }
                else
                {
                    _mailMessage.CC.Add(CC);
                }
            }
            switch (Priority) { 
                case "H":
                    _mailMessage.Priority = MailPriority.High;
                    break;
                case "L":
                    _mailMessage.Priority = MailPriority.Low;
                    break;
                default:
                    _mailMessage.Priority = MailPriority.Normal;
                    break;
            }
            
            _mailMessage.IsBodyHtml = true;
            object userState = _mailMessage;
            _smtpClient.SendAsync(_mailMessage, userState);
        }
        public  void sendError(string body)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Host = strHost;
            _smtpClient.UseDefaultCredentials = IsCredentials;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Credentials = new NetworkCredential(CredentialsID, IsCredentialsPWD); 
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress(strFrom, MailSenderShow);
            _mailMessage.To.Add(TempMailto);
            _mailMessage.Subject = "程序异常！";
            _mailMessage.Body = body;
            _mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            _mailMessage.IsBodyHtml = true;
            object userState = _mailMessage;
            _smtpClient.SendAsync(_mailMessage, userState);
        }

        public void SendmailForTitle(string p)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Host = strHost;
            _smtpClient.UseDefaultCredentials = IsCredentials;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Credentials = new NetworkCredential(CredentialsID, IsCredentialsPWD);
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress(strFrom, MailSenderShow);
            _mailMessage.To.Add(TempMailto);
            _mailMessage.Subject = "Title变更！";
            _mailMessage.Body = p;
            _mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            _mailMessage.IsBodyHtml = true;
            object userState = _mailMessage;
            _smtpClient.SendAsync(_mailMessage, userState);
        }
    }

}
