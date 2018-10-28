using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AuthenticationBasedProject.DatabaseConnection
{
    public class LoginUserFirstName
    {
        public string UserFirstName(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string firstName = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select FirstName from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                firstName += (string)cmd.ExecuteScalar();

            }
            return firstName;
        }
    }
}