using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace DIU_CPC_BlueDivision.ForgetPasswordClass
{
    public class EMail : IIdentityMessageService
    {
        #region Interface Implementation
        public async Task SendAsync(IdentityMessage message)
        {
            await configSendGridasync(message);
        }
        #endregion

        #region Send Email Method
        public async Task configSendGridasync(IdentityMessage message)
        {
            try
            {
                string senderEmail = ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["senderPassword"].ToString();
                string smtpClient = ConfigurationManager.AppSettings["SMTPClient"].ToString();
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());
                bool enableSSL = bool.Parse(ConfigurationManager.AppSettings["EnableSSL"].ToString());

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(senderEmail);
                msg.To.Add(message.Destination);
                msg.Subject = message.Subject;
                msg.Body = message.Body;
                msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(smtpClient, smtpPort);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = enableSSL;
                smtp.Send(msg);
                smtp.Dispose();
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}