using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Company.WebForm
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("BlogTableProcedureMainPage", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataList1.DataSource = rdr;
                DataList1.DataBind();

            }
        }
        protected string GetImage1(object oItem)
        {
            // read the data from database
            var cImgSrc = DataBinder.Eval(oItem, "BlogImage") as byte[];

            // if we do not have any image, return some default.

            if (cImgSrc == null)
            {
                return "<img src=\"../Image/crose.jpg\" alt=\"image\" style=\"width: 319px; height:235px\" class=\"img-responsive\">";
            }
            else
            {
                // format and render back the image
                return String.Format("<img src=\"data:image/jpg;base64,{0}\" alt=\"image\" style=\"width: 319px; height:235px\" class=\"img-responsive\"/>",
                    Convert.ToBase64String((byte[])cImgSrc));

            }
        }
        protected string GetTitle1(object oItem)
        {
            var str = DataBinder.Eval(oItem, "Title") as string;
            string str1 = str.ToString();
            if (str1.Length > 160)
            {
                StringBuilder sb = new StringBuilder(str1);
                sb.Remove(160, sb.Length - 160);
                str1 = sb.ToString() + "...";
            }
            return str1;
        }
    }
}