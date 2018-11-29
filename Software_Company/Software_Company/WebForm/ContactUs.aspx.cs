using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Software_Company.WebForm
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "PersonMessageProcedure";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string name = Name1.Text.Trim();
                string phone = Phone1.Text.Trim();
                string email = Email1.Text.Trim();
                string address = Address1.Text.Trim();
                string message = Message1.Text.Trim();

                if (name != string.Empty && phone != string.Empty && email != string.Empty &&
                    address != string.Empty && message != string.Empty)
                {

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.ExecuteNonQuery();
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "alertMe()", true);

                    //get current url (Preventing form resubmission)
                    string url = HttpContext.Current.Request.Url.AbsoluteUri;
                    Response.Redirect(url);
                }
            }
        }
    }
}