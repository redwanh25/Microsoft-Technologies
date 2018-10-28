using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace BFWeb
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            FormsAuthentication.SignOut();

            // Invalidate roles token
            Response.Cookies["BestowerSoftUser"].Value = "";
            Response.Cookies["BestowerSoftUser"].Path = "/";
            Response.Cookies["BestowerSoftUser"].Expires = new System.DateTime(1999, 10, 12);

            Context.User = null;
            Response.Redirect("Login.aspx", false);
        }
    }
}
