using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jQuery_ASP_Bootstrap_Tutorial.ASP_Tutorial.ASP_1_To_10
{
    public partial class ViewState_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["count"] == null)
                {
                    ViewState["count"] = 0;
                }

                TextBox1.Text = ViewState["count"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["count"] != null)
            {
                TextBox1.Text = (Convert.ToInt32(ViewState["count"]) + 1).ToString();
                ViewState["count"] = TextBox1.Text;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\ASP_Tutorial\ASP_1_To_10\ViewState_2.aspx");
        }
    }
}