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
using CIS.Lib.Utils;

namespace BFWeb
{
    public partial class ListTemplates : System.Web.UI.Page
    {
        public int roleId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            roleId = Convert.ToInt32(AppSecurity.GetUserRole());

            CIS.Lib.DALC.Templates t = new CIS.Lib.DALC.Templates();
            DataSet ds = t.Find(string.Empty, " ORDER BY Name");

            //DataSet ds = t.Find(AppSetting.GetConnString(), "Templates", string.Empty, " ORDER BY Name");
                
           
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
            Response.Redirect("TemplateDetails.aspx");
        }
    }
}
