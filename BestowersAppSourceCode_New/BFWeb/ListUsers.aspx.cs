using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CIS.Lib.DALC;

namespace BFWeb
{
    public partial class ListUsers : System.Web.UI.Page
    {
        public int roleId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            roleId = Convert.ToInt32(AppSecurity.GetUserRole());

            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            DataSet ds = u.Find(string.Empty, string.Empty);

            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            repParent.DataSource = ds.Tables[0].DefaultView;
            repParent.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserDetails.aspx");
        }
    }
}
