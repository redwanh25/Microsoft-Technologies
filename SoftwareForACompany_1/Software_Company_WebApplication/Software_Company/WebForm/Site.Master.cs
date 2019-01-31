using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Software_Company.WebForm
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void sendClick(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "dbo.PersonMessageProcedure";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string name = Name.Text.Trim();
                string phone = Phone.Text.Trim();
                string email = Email.Text.Trim();
                string address = Address.Text.Trim();
                string message = Message.Text.Trim();

                if (name != string.Empty && phone != string.Empty && email != string.Empty &&
                    address != string.Empty && message != string.Empty)
                {

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.ExecuteNonQuery();
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "alertMe()", true);
                    string textEmail = "Name: " + name + ".<br>PhoneNumber: " + phone + ".<br>Email: " + email + ".<br>Address: " + address + ".<br><br>Message: " + message;

                    bool result = false;
                    result = sendMain("redwan15-8557@diu.edu.bd", "This Person Want To Contact With Us.", textEmail);
                    if (result == true)
                    {
                        //System.Threading.Thread.Sleep(5000);
                        //cmd.ExecuteNonQuery();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message has been sent successfully');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message sent failed');", true);
                    }

                    //get current url (Preventing form resubmission)
                    string url = HttpContext.Current.Request.Url.AbsoluteUri;
                    Response.Redirect(url);
                }
            }
        }

        public bool sendMain(string toEmail, string subject, string emailBody)
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