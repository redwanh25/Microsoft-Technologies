using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading;
using System.Globalization;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using CIS.Lib.DALC;
using System.Diagnostics;

namespace BFWeb
{
    public class Global : System.Web.HttpApplication
    {

        // Constants used to reference data stored in cookies
        public const string BestowerSoftUser = "BestowerSoftUser";

        

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        

        //*********************************************************************
        //
        // Application_AuthenticateRequest Event
        //
        // If the client is authenticated with the application, then determine
        // which security roles he/she belongs to and replace the "User" intrinsic
        // with a custom IPrincipal security object that permits "User.IsInRole"
        // role checks within the application
        //
        // Roles are cached in the browser in an in-memory encrypted cookie.  If the
        // cookie doesn't exist yet for this session, create it.
        //
        //*********************************************************************

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            string userInformation = String.Empty;

            if (Request.IsAuthenticated == true)
            {
               
                // Create the roles cookie if it doesn't exist yet for this session.
                if ((Request.Cookies[BestowerSoftUser] == null) || (Request.Cookies[BestowerSoftUser].Value == ""))
                {
                    // Retrieve the user's role and ID information and add it to
                    // the cookie
                    AppUser user = new AppUser(User.Identity.Name);
                    if (user.Load())
                    {
                        // Create a string to persist the role and user id 
                        userInformation = user.UserID.ToString() + ";" + user.Role + ";" + user.OrganizationID.ToString();
                        //CIS.Lib.Utils.Utility.WriteLog(string.Empty, userInformation, "AFTER LOAD USER INFORMAITON FROM GLOBAL.ASX");

                    }

                    //CIS.Lib.Utils.Utility.WriteLog(string.Empty, userInformation, "CREATING TICKET ");

                    // Create a cookie authentication ticket.
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                        1,                              // version
                        User.Identity.Name,			    // user name
                        DateTime.Now,                   // issue time
                        DateTime.Now.AddHours(2),       // expires every 2 hour
                        false,                          // don't persist cookie
                        userInformation
                        );

                    // Encrypt the ticket
                    String cookieStr = FormsAuthentication.Encrypt(ticket);

                    //CIS.Lib.Utils.Utility.WriteLog(string.Empty, cookieStr, "WRITING COOKIE ENCRYPTED  ");

                    // Send the cookie to the client
                    Response.Cookies[BestowerSoftUser].Value = cookieStr;
                    Response.Cookies[BestowerSoftUser].Path = "/";
                    Response.Cookies[BestowerSoftUser].Expires = DateTime.Now.AddHours(2);

                    // Add our own custom principal to the request containing the user's identity, the user id, and
                    // the user's role 
                    Context.User = new CustomPrincipal(User.Identity, user.UserID, user.Role, user.OrganizationID);
                }
                else
                {
                    //string existingCookieVal = Context.Request.Cookies[BestowerSoftUser].Value;
                    //CIS.Lib.Utils.Utility.WriteLog(string.Empty, existingCookieVal, "ELSE EXISTING ENCRIPTIED COOKIE VALUE ");
                    
                    
                    // Get roles and organization from cookie and decrypt it
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(Context.Request.Cookies[BestowerSoftUser].Value);
                    userInformation = ticket.UserData;

                    //CIS.Lib.Utils.Utility.WriteLog(string.Empty, userInformation, "ELSE USER INFORMAITON PULLED FROM COOKIE");

                    // Add our own custom principal to the request containing the user's identity, the user id, and
                    // the user's role from the auth ticket
                    string[] info = userInformation.Split(new char[] { ';' });
                    Context.User = new CustomPrincipal(
                        User.Identity,
                        Convert.ToInt32(info[0].ToString()),
                        info[1].ToString(),
                        Convert.ToInt32(info[2].ToString()));

                }
            }
        }


        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}