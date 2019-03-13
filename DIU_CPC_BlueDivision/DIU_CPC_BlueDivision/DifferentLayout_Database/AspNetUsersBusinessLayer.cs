using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DifferentLayout_Database
{
    public class AspNetUsersBusinessLayer
    {
        public string GetSecureCode(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string id = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select SecureCode from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                id += (string)cmd.ExecuteScalar();

            }
            return id;
        }
    }
}