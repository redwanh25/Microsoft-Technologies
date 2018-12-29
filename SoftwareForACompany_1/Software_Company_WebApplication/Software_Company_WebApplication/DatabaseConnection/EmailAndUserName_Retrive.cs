using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class EmailAndUserName_Retrive
    {
        public string GetUserName(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string userName = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select UserName from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                userName += (string)cmd.ExecuteScalar();

            }
            return userName;
        }
        public string GetEmailId(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string emailId = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select Email from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                emailId += (string)cmd.ExecuteScalar();

            }
            return emailId;
        }
    }
}