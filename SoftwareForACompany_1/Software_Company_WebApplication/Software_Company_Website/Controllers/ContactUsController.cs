using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class ContactUsController : Controller
    {
        private ContactUs_DBEntities db = new ContactUs_DBEntities();

        // GET: ContactUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone_Number,Email,Address,Message")] PersonMessage_tbl personMessage_tbl)
        {
            if (ModelState.IsValid)
            {
                personMessage_tbl.Date = DateTime.Now;
                db.PersonMessage_tbl.Add(personMessage_tbl);
                db.SaveChanges();

                string textEmail = "Name: " + personMessage_tbl.Name + ".<br>PhoneNumber: " + personMessage_tbl.Phone_Number + ".<br>Email: " + personMessage_tbl.Email + ".<br>Address: " + personMessage_tbl.Address + ".<br><br>Message: " + personMessage_tbl.Message;
                bool result = false;
                result = sendMail("redwanh25@gmail.com", "This Person Want To Contact With Us.", textEmail);

                if (result == true)
                {
                    //db.SaveChanges();
                }
                else
                {
                    
                }
                return RedirectToAction("Create");
            }

            return View(personMessage_tbl);
        }

        public bool sendMail(string toEmail, string subject, string emailBody)
        {
            try
            {
                string senderEmail = ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["senderPassword"].ToString();

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                //SmtpClient client = new SmtpClient("relay-hosting.secureserver.net", 25);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, toEmail, subject, emailBody);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
