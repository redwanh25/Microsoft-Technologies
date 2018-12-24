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
                // DataList1.RepeatColumns = 3;         // ai tar jonno multiple column toiri hoye jabe.

                //      | | | |         emon vabe show korbe image. like youtube video.
                //      | | | |
                //      | | | |

            }
        }

        protected string GetImage1(object oItem)
        {
            // read the data from database
            var cImgSrc = DataBinder.Eval(oItem, "BlogImage") as byte[];

            // if we do not have any image, return some default.

            if (cImgSrc == null)
            {                                               // style=\"width: 319px; height:235px\"
                return "<img src=\"../Image/crose.jpg\" alt=\"image\" style=\"width: 310px; height:190px\" class=\"img-responsive\">";
            }
            else
            {
                // format and render back the image
                return String.Format("<img src=\"data:image/jpg;base64,{0}\" alt=\"image\" style=\"width: 350px; height:190px\" class=\"img-responsive\"/>",
                    Convert.ToBase64String((byte[])cImgSrc));

            }
        }
        protected string GetTitle1(object oItem)
        {
            var str = DataBinder.Eval(oItem, "Title") as string;
            string str1 = str.ToString();
            if (str1.Length > 80)
            {
                StringBuilder sb = new StringBuilder(str1);
                sb.Remove(80, sb.Length - 80);
                str1 = sb.ToString() + "...";
            }
            return str1;
        }
        protected string GetButton1(object oItem)
        {
            var str = DataBinder.Eval(oItem, "BlogDivId") as string;
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            Uri uri = new Uri(url);
            string address = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":"+ uri.Port + "/WebForm/Blog.aspx#" + str;
            return String.Format("<a href=\"{0}\" class=\"btn btn-default btn-block\" style=\"border-radius: 20px; outline: none; color: orange; font-size: 15px\">Get More Info</a>", address);
        }

        // for responsive feature. top 4 blog post.
        protected void OnClick(object sender, EventArgs e)
        {
            int repeatcolumn = Convert.ToInt32(hfColumnRepeat.Value);
            this.RsetepeatColumns(repeatcolumn);
        }
        private void RsetepeatColumns(int repeatcolumn = 4)
        {
            DataList1.RepeatColumns = repeatcolumn;
        }
    }
}