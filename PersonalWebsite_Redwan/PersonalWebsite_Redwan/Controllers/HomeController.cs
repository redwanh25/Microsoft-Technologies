using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite_Redwan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Controllers/Home/Contact")]
        public ActionResult ContactPopUp(string name, string email, string subject, string message)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(subject) && !string.IsNullOrEmpty(message))
            {
                string textEmail = "Name: " + name + ".<br>Email: " + email + ".<br>Subject: " + subject + ".<br><br>Message: " + message;
                result = sendMailForGmail(subject, textEmail);

                if (result == true)
                {
                    return Json(new { status = "Success" });
                }
                else
                {
                    return Json(new { status = "Error" });
                }
            }
            else
            {
                throw new Exception();
            }
        }

        public bool sendMailForGmail(string subject, string emailBody)
        {
            try
            {
                string senderEmail = ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["senderPassword"].ToString();
                string receiverEmail = ConfigurationManager.AppSettings["receiverEmail"].ToString();
                string smtpClient = ConfigurationManager.AppSettings["SMTPClient"].ToString();
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());

                SmtpClient client = new SmtpClient(smtpClient, smtpPort);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail, subject, emailBody);
                mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = Encoding.UTF8;
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool sendMailForPersonal(string subject, string emailBody)
        {
            try
            {
                string senderEmail = ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["senderPassword"].ToString();
                string receiverEmail = ConfigurationManager.AppSettings["receiverEmail"].ToString();
                string smtpClient = ConfigurationManager.AppSettings["SMTPClient"].ToString();
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(senderEmail);
                msg.To.Add(receiverEmail);
                msg.Subject = subject;
                msg.Body = emailBody;
                msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(smtpClient, smtpPort);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = false;
                smtp.Send(msg);
                smtp.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        }
}