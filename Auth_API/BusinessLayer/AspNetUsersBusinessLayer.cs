using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AspNetUsersBusinessLayer
    {
        public int UserLoginId(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            int id = -1;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select UserId from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                id = (int)cmd.ExecuteScalar();

            }
            return id;
        }
    }
}
