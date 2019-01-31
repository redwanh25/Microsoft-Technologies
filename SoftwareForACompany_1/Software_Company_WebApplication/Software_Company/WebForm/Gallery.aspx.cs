using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Company.WebForm
{
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand("GalleryTableProcedure", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    DataList2.DataSource = rdr;
            //    DataList2.DataBind();
            //    // DataList1.RepeatColumns = 3;         // ai tar jonno multiple column toiri hoye jabe.

            //    //      | | | |         emon vabe show korbe image. like youtube video.
            //    //      | | | |
            //    //      | | | |

            //}
        }
        //protected void OnClick(object sender, EventArgs e)
        //{
        //    int repeatcolumn = Convert.ToInt32(hfColumnRepeat.Value);
        //    this.RsetepeatColumns(repeatcolumn);
        //}

        //private void RsetepeatColumns(int repeatcolumn = 4)
        //{
        //    DataList2.RepeatColumns = repeatcolumn;
        //}

        protected string GetImage2(object oItem)
        {
            // read the data from database
            var cImgSrc = DataBinder.Eval(oItem, "GalleryImage") as byte[];

            // if we do not have any image, return some default.

            if (cImgSrc == null)
            {                                               // style=\"width: 319px; height:235px\"
                return "<img src=\"../Image/crose.jpg\" alt=\"image\" style=\"width: 310px; height:190px\" class=\"img-responsive\">";
            }
            else
            {
                //if (ViewState["countG"] == null)
                //{
                //    ViewState["countG"] = 0;
                //}
                //int i = (int)ViewState["countG"] + 1;
                //ViewState["countG"] = i;
                //string str = String.Format("../GalleryImage/Hello{0}.jpg", i);
                //Base64ToImage(Convert.ToBase64String((byte[])cImgSrc)).Save(System.Web.HttpContext.Current.Server.MapPath(str));
                //return String.Format("<a class=\"lightbox\" href=\"{0}\"><img style=\"width: 320px; height:200px\" src=\"data:image/jpg;base64,{1}\" alt=\"image\" class=\"img-responsive\"/></a>",
                //   str, Convert.ToBase64String((byte[])cImgSrc));

                // format and render back the image                                             style=\"width: 330px; height:250px\"
                return String.Format("<img src=\"data:image/jpg;base64,{0}\" alt=\"image\" style=\"width: 320px; height:200px\" class=\"img-responsive\"/>",
                    Convert.ToBase64String((byte[])cImgSrc));

            }
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