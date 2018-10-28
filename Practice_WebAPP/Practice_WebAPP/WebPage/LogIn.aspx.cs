using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Practice_WebAPP.WebPage
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from tblPerson; select * from tblDepartment; select * from tblEmployee";
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    tblPerson.DataSource = rdr;
                    tblPerson.DataBind();

                    while (rdr.NextResult())
                    {
                        tblDepartment.DataSource = rdr;
                        tblDepartment.DataBind();

                        while (rdr.NextResult())
                        {
                            tblEmployee.DataSource = rdr;
                            tblEmployee.DataBind();
                        }
                    }
                    
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                
                cmd.CommandText = "insert into tblnew values (@ProductName)";
                cmd.Parameters.AddWithValue("@ProductName", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select * from tblnew";
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                //   cmd.CommandText = "Select * from tblnew Where [product_name] like '" + TextBox2.Text + "%'";      // do not try this. if you do this our data will be hacked by hacker

                cmd.CommandText = "select * from tblnew where [product_name] like @product_name";       // parameterize query
                cmd.Parameters.AddWithValue("@product_name", TextBox2.Text + "%");
                //   cmd.CommandText = "StoredProcedure";
                //   cmd.CommandType = System.Data.CommandType.StoredProcedure;
               // cmd.Parameters.AddWithValue("@ProductName", TextBox2.Text + "%");   // stored procedure a korle "@ProductName" ai nam r sql a use kora name same hote hobe
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}