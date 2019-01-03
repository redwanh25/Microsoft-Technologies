using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
                if (ViewState["count"] == null)
                {
                    ViewState["count"] = 0;
                }
                int i = (int)ViewState["count"] + 1;
                ViewState["count"] = i;
                string str = String.Format("../BlogImage/Hello{0}.jpg", i);
                ViewState["imageUrl"] = str;
                Base64ToImage(Convert.ToBase64String((byte[])cImgSrc)).Save(Server.MapPath(str));

                // format and render back the image
                //return String.Format("<img style=\"border-radius: 10px;\" src=\"data:image/jpg;base64,{0}\" alt=\"image\" class=\"img-responsive\"/> <br/>",
                //    Convert.ToBase64String((byte[])cImgSrc));

                return String.Format("<a class=\"lightbox\" href=\"{0}\"><img style=\"border-radius: 10px;\" src=\"data:image/jpg;base64,{1}\" alt=\"image\" class=\"img-responsive\"/></a> <br/>",
                    str, Convert.ToBase64String((byte[])cImgSrc));
                
            }
        }

        protected string GetFacebookShare(object oItem)
        {
            var str = DataBinder.Eval(oItem, "BlogDivId") as string;
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            Uri uri = new Uri(url);
            string address = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":" + uri.Port + "/WebForm/Blog.aspx%23" + str;
            return String.Format("<iframe src=\"https://www.facebook.com/plugins/share_button.php?href={0}&layout=button_count&size=large&mobile_iframe=true&appId=377299629711169&width=103&height=28\" width=\"103\" height=\"28\" style=\"border:none;overflow:hidden\" scrolling=\"no\" frameborder=\"0\" allowTransparency=\"true\" allow=\"encrypted-media\"></iframe>", address);
        }

        protected string GetLinkedInShare(object oItem)
        {
            var str = DataBinder.Eval(oItem, "BlogDivId") as string;
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            Uri uri = new Uri(url);
            string address = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":" + uri.Port + "/WebForm/Blog.aspx%23" + str;
            return String.Format("<a href=\"https://www.linkedin.com/shareArticle?mini=true&url={0}&title=Nai&summary=Nai&source=Nai\" onclick =\"window.open(this.href, 'mywin','left=20,top=20,width=700,height=450,toolbar=1,resizable=0'); return false;\" ><img src=\"../Image/linkedin.png\" alt=\"Image Upload hoyni\" height=\"35\"/></a>", address);
        }

        //byte code to image
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}