using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using CIS.Lib.DALC;
using System.Net.Mail;
using CIS.Lib.Utils;

namespace BFWeb
{
    public partial class BestowerSoftLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If authenticated and accessed to login page again ... let user in
            if (Request.IsAuthenticated)
                Response.Redirect("BestowerSoft.aspx");


        }



        //*************************************************
        // Object name: SignIn 
        // When user click 'Login' button btnLogin_Click mthod is executed
        //*************************************************
        protected void btnLogin_Click(object sender, System.EventArgs e)
        {

            if (username.Text.Equals("") || password.Text.Equals(""))
            {
                message.Text = "Invalid Credential";
                return;
            }
            AppUser user = new AppUser();
            string encryptedPassword = AppSetting.Encrypt(password.Text);            
            bool isAuthenticated = user.Login(username.Text, encryptedPassword);
          
            if (isAuthenticated)
            {
                // Redirect browser back to originating page
                FormsAuthentication.RedirectFromLoginPage(username.Text, false);
            }
            else
            {
                panelLogin.Visible = true;
                panelSendPassword.Visible = false;
                message.Text = "Login Failed!";
            }

        }

        protected void btnSendPassword_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Equals("") || tbEmail.Text.Equals(""))
            {
                labelMsg.Text = "Invalid Username and Email";
                return;
            }

            string sEmail = tbEmail.Text;
            string sUserName = tbUserName.Text;

            AppUser u = new AppUser();

            if (u.Load(sUserName, sEmail))
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("reza.nabi@comcast.net");
                msg.To.Add(new MailAddress(sEmail));
                msg.CC.Add(new MailAddress("reza.nabi@gmail.com"));
                msg.Subject = "Your Bestower Accounting Software Credential";
                msg.Body = @"  <html>
						   <body>
							 Your credentials to logon Bestower Accounting Software are:<br>
                             User Name: <font color='blue'>" + u.UserName + @"</font> <br>
							 Password: <font color='blue'>" + AppSetting.Decrypt(u.Password) + @"</font> <br><br>
							 If you have any questions, please contact development team dt@bestower.com <br>
                             Thank you.
						   </body>
						   </html>";

                msg.IsBodyHtml = true;

                // SMTP Client
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential("reza.nabi@gmail.com", "Mar2018!6224!");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                try
                {
                    // sent message
                    client.Send(msg);

                    message.Text = "Password sent to " + sEmail;
                    username.Text = u.UserName;
                    password.Text = "";
                    panelLogin.Visible = true;
                    panelSendPassword.Visible = false;

                }
                catch (Exception ex)
                {

                    message.Text = "Error occured while sending your message." + ex.Message;
                }




            }
            else
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("reza@ksu.edu");
                msg.To.Add(new MailAddress("reza@nabi.us"));
                msg.CC.Add(new MailAddress("reza.nabi@gmail.com"));
                msg.Subject = "PMSD Password lookup failed";
                msg.Body = @"  <html>
						   <body>
							 No records were found with the following credential:<br>
                             User Name: <font color='blue'>" + sUserName + @"</font> <br>
							 Email: <font color='blue'>" + sEmail + @"</font> <br><br>
							 If you have any questions, please contact Administrator at sdeloach@ksu.edu <br>
                             Thank you.
						   </body>
						   </html>";
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.Send(msg);

                labelMsg.Text = "Email [" + sEmail + "] does not exists";
                panelLogin.Visible = false;
                panelSendPassword.Visible = true;
            }
        }


        protected void lbForgotPassword_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSendPassword.Visible = true;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSendPassword.Visible = false;
        }

    }
}
