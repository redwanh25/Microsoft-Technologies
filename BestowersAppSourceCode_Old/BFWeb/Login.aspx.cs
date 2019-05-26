using System;
using System.Collections.Generic;
using CIS.Lib.DALC;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace BFWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Request.IsAuthenticated)
           //     Response.Redirect("./JoinTheFoundation.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Attempt to Validate User Credentials using UsersDB
            AppUser user = new AppUser();
            bool isAuthenticated = user.Login(username.Text, password.Text);
            if (isAuthenticated)
            {
                // first check if password expired. If expires force user to change the password
                user.Load(username.Text);
                if (user.PasswordExpired)
                {
                    panelLogin.Visible = false;
                    //LabelCPUserName.Text = username.Text;
                    //LabelCPOldPassword.Text = password.Text;
                    panelCP.Visible = true;
                }
                else
                {
                    // Redirect browser back to originating page
                    FormsAuthentication.RedirectFromLoginPage(username.Text, false);
                }
            }
            else
            {
                panelLogin.Visible = true;
                panelCP.Visible = false;
                message.Text = "Login Failed!";
            }	
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPass = password.Text;
            string currentUserName = username.Text;
            AppUser user = new AppUser();
            if (TextboxCPNewPassword1.Text.Length < 4)
            {
                panelLogin.Visible = false;
                panelCP.Visible = true;
                labelMsg.Text = "Password must be at least 4 chars long.";
            }
            else if (!(TextboxCPNewPassword1.Text.Equals(TextboxCPNewPassword2.Text)))
            {
                panelLogin.Visible = false;
                panelCP.Visible = true;
                labelMsg.Text = "New passwords did not match.";
            }
            else if ((TextboxCPNewPassword1.Text.Equals(currentPass)))
            {
                panelLogin.Visible = false;
                panelCP.Visible = true;
                labelMsg.Text = "Password can not be current password.";
            }
            else
            {
                bool passChanged = user.ChangePassword(currentUserName, TextboxCPNewPassword1.Text);
                if (passChanged)
                {
                    // Redirect browser back to originating page
                    FormsAuthentication.RedirectFromLoginPage(currentUserName, false);
                }
                else
                {
                    panelLogin.Visible = false;
                    panelCP.Visible = true;
                    labelMsg.Text = "Password did not change.";
                }
            }
        }
    }
}
