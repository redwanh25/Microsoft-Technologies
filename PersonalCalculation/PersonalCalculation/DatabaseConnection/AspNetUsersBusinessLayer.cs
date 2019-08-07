using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonalCalculation.DatabaseConnection
{
    public class AspNetUsersBusinessLayer
    {
        public string GetUserCode(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string id = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select UserCode from AspNetUsers where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                id += (string)cmd.ExecuteScalar();

            }
            return id;
        }

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

        public void UpdatePhoneNumber(string id, string phoneNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    cmd.CommandText = "update dbo.AspNetUsers set PhoneNumber = @phoneNumber where Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                }
                else
                {
                    cmd.CommandText = "update dbo.AspNetUsers set PhoneNumber = null where Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}