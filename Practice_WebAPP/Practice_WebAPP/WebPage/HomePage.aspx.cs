using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Practice_WebAPP.WebPage
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //  string str = "data source = DESKTOP-EGK8K73; database = Sample; integrated security = SSPI";
            string str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))      // connection off kore deoyar jonno using deoya hoise.
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select count(id) from tblPerson";
                int rd = (int)cmd.ExecuteScalar();
                Response.Write(rd);

                cmd.CommandText = "update tblPerson set salary = 1500 where id = 9";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select * from tblPerson";
                SqlDataReader rd1 = cmd.ExecuteReader();
                GridView1.DataSource = rd1;
                GridView1.DataBind();       // DataBind() use na korle output show korbe na.
                rd1.Close();

                cmd.CommandText = "select * from tblDepartment";
                SqlDataReader rd2 = cmd.ExecuteReader();
                GridView2.DataSource = rd2;
                GridView2.DataBind();
                rd2.Close();

                cmd.CommandText = "select * from tblEmployee";
                SqlDataReader rd3 = cmd.ExecuteReader();
                GridView3.DataSource = rd3;
                GridView3.DataBind();
                rd3.Close();
            }

        }

    }
}