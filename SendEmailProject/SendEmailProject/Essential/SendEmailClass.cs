using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SendEmailProject.Essential
{
    public class SendEmailClass
    {
        public bool SendMail(string value, string email)
        {
            try
            {
                string senderEmail = ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["senderPassword"].ToString();
                string receiverEmail = email;
                string smtpClient = ConfigurationManager.AppSettings["SMTPClient"].ToString();
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"].ToString());

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(senderEmail);
                msg.To.Add(receiverEmail);
                if (value == "SalesOrder")
                {
                    msg.Subject = "Sales Order";
                    msg.Body = CreateBody_SalesOrder();
                }
                else if (value == "Receipt")
                {
                    msg.Subject = "Receipt";
                    msg.Body = CreateBody_Receipt();
                }
                
                msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(smtpClient, smtpPort);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = false;
                smtp.Send(msg);
                smtp.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string CreateBody_SalesOrder()
        {
            string body = "";
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/Essential/SalesOrder.html")))
            {
                body = reader.ReadToEnd();
            }
            //body = body.Replace("{username}", "redwan");
            return body;
        }
        public string CreateBody_Receipt()
        {
            string body = "";
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/Essential/Receipt.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("@COMPANY_NAME", "US Bangla Test 13-06-21");
            body = body.Replace("@COMPANY_ADDRESS1", "46 Kazi Nazrul Islam Avenue");
            body = body.Replace("@COMPANY_ADDRESS2", "Karwan Bazaar, Dhaka-1205");
            body = body.Replace("@VOUCHER_NAME", "Receipt");
            body = body.Replace("@V_TYPE", "RV0001RV#000001");
            body = body.Replace("@DATE", "15-06-2021");
            return body;
        }
    }
}