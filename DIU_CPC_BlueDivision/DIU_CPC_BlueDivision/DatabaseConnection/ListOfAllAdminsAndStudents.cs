using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class ListOfAllAdminsAndStudents
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

        public void DeleteAdmins(string id)
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

        public void DeleteAdmin_1s(string id)
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

        public void UpdateStudentsMute(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update dbo.students set MuteOrUnmute = 'Mute' where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudentsUnmute(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update dbo.students set MuteOrUnmute = 'Unmute', Request = 0 where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string CheckMuteOrUnmute(string id)
        {
            string value = "";
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MuteOrUnmute from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();

                value = (string) cmd.ExecuteScalar();
            }
            return value;
        }

        public void UpdateStudentsRequest(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update dbo.students set Request = 1 where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}