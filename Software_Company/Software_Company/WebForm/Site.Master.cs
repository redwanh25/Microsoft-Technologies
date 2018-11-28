using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Software_Company.WebForm
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void sendClick(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "PersonMessageProcedure";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string name = Name.Text.Trim();
                string phone = Phone.Text.Trim();
                string email = Email.Text.Trim();
                string address = Address.Text.Trim();
                string message = Message.Text.Trim();

                if (name != string.Empty && phone != string.Empty && email != string.Empty &&
                    address != string.Empty && message != string.Empty)
                {

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}