using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class ListOfAllBlueSheetStudents
    {
        public void DeleteStudents(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from AspNetUsers where id = @parameter";
                cmd.Parameters.AddWithValue("@parameter", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudentsByUserName(string userName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from AspNetUsers where UserName = @userName";
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}