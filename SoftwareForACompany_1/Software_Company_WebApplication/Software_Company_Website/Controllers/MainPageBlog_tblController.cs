using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class MainPageBlog_tblController : Controller
    {
        private BlogTableMainPageDBEntities db = new BlogTableMainPageDBEntities();

        // GET: MainPageBlog_tbl
        public ActionResult Index()
        {
            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).Take(4).ToList();
            return View(list);
        }

        // GET: MainPageBlog_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }
            return View(blog_tbl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private void attachParameters(SqlCommand cmd, string parameterName, string value)
        {
            if (value != string.Empty)
            {
                SqlParameter parameter = new SqlParameter(parameterName, value);
                cmd.Parameters.Add(parameter);
            }
        }

        [HttpPost]
        [Route("Controllers/MainPageBlog_tbl/ContactPopUp")]
        public void ContactPopUp(string name, string email, string phoneNumber, string address, string message)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PersonMessageProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                attachParameters(cmd, "@Name", name);
                attachParameters(cmd, "@Email", email);
                attachParameters(cmd, "@PhoneNumber", phoneNumber);
                attachParameters(cmd, "@Address", address);
                attachParameters(cmd, "@Message", message);

                con.Open();
                cmd.ExecuteNonQuery();

                string textEmail = "Name: " + name + ".<br>PhoneNumber: " + phoneNumber + ".<br>Email: " + email + ".<br>Address: " + address + ".<br><br>Message: " + message;
                bool result = false;
                result = sendMail("redwanh25@gmail.com", "This Person Want To Contact With Us.", textEmail);

                if (result == true)
                {
                    //cmd.ExecuteNonQuery();
                }
                else
                {

                }
            }
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
    }
}
