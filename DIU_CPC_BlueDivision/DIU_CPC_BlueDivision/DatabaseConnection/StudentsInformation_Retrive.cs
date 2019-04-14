using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class StudentsInformation_Retrive
    {
        public string GetUserName(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string userName = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select UserName from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                userName += (string) cmd.ExecuteScalar();
            }
            return userName;
        }

        public string GetEmailId(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string emailId = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select EmailAddress from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                emailId += (string)cmd.ExecuteScalar();
            }
            return emailId;
        }

        public string GetSemester(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string semester = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select Semester from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                semester += (string)cmd.ExecuteScalar();
            }
            return semester;
        }

        public int GetSolveCount(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            int solveCount = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select SolveCount from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                solveCount = (int)cmd.ExecuteScalar();
            }
            return solveCount;
        }

        public string GetMuteOrUnmute(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string muteOrUnmute = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select MuteOrUnmute from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                muteOrUnmute += (string)cmd.ExecuteScalar();
            }
            return muteOrUnmute;
        }

        public int GetRequest(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            int request = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select Request from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                request = (int)cmd.ExecuteScalar();
            }
            return request;
        }

        public bool hasImage(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select StudentImage from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                object obj = cmd.ExecuteScalar();
                if (obj.GetType() == typeof(DBNull))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public byte[] StudentImageByte(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            byte[] imgByte = new byte[byte.MaxValue - 2];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select StudentImage from dbo.Students where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                object obj = cmd.ExecuteScalar();
                if (obj.GetType() == typeof(DBNull))
                {
                    return null;
                }
                else
                {
                    imgByte = (byte[])cmd.ExecuteScalar();
                } 
            }
            return imgByte;
        }

        public void StoreProfilePic(string id, byte[] stuImage)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update dbo.Students set StudentImage = @stuImage where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@stuImage", stuImage);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProfilePicture(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update dbo.Students set StudentImage = null where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}