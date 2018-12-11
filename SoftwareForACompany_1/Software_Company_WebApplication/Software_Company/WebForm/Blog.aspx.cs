using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Company.WebForm
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("BlogTableProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@Id", 7);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();

                //while (rdr.Read())
                //{
                //    TitleName1.Text = Convert.ToString(rdr["Title"]);
                //    DateTime1.Text = Convert.ToDateTime(rdr["Date"]).ToString();

                //    byte[] bytes = (byte[])rdr["BlogImage"];
                //    string strBase64 = Convert.ToBase64String(bytes);
                //    Image1.ImageUrl = "data:Image/png;base64," + strBase64;

                //    TextBox1.Text = Convert.ToString(rdr["Text"]);
                //}

            }
        }
        protected string GetImage(object oItem)
        {
            // read the data from database
            var cImgSrc = DataBinder.Eval(oItem, "BlogImage") as byte[];

            // if we do not have any image, return some default.
            if (cImgSrc == null)
            {
                return "<img src=\"empty.gif\" style=\"height:0px; width:0px\">";
            }
            else
            {
                // format and render back the image
                return String.Format("<img style=\"border-radius: 10px;\" src=\"data:image/jpg;base64,{0}\" alt=\"image\" class=\"img-responsive\"/> <br/>",
                    Convert.ToBase64String((byte[])cImgSrc));
            }
        }
    }
}