﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

        public ActionResult RedwanHossain_CV()
        {
            string filePath = "~/My_CV/Redwan Hossain (CV).pdf";
            return File(filePath, "application/pdf");
        } 

        [HttpPost]
        [Route("Controllers/Home/Contact")]
        public ActionResult ContactPopUp(string name, string email, string subject, string message)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(subject) && !string.IsNullOrEmpty(message))
            {
                string textEmail = "Name: " + name + ".<br>Email: " + email + ".<br>Subject: " + subject + ".<br><br>Message: " + message;
                //result = sendMailForGmail(subject, textEmail);
                result = sendMailForPersonal(name, email, subject, message);

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

        public bool sendMailForPersonal(string name, string email, string subject, string message)
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
                msg.Body = CreateBody(name, email, subject, message);
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

        public string CreateBody(string name, string email, string subject, string message)
        {
            string body = "";
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Html_Page/EmailTamplate.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{name}", name);
            body = body.Replace("{email}", email);
            body = body.Replace("{subject}", subject);
            body = body.Replace("{message}", message);
            return body;
        }

    }
}