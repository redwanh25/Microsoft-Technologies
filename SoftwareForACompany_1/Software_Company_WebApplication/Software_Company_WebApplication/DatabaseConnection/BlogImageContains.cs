using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class BlogImageContains
    {
        public bool hasImage(int str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select BlogImage from Blog_tbl where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
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
        public byte[] EmpImageByte(int str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            byte[] imgByte = new byte[byte.MaxValue - 2];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select BlogImage from Blog_tbl where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                imgByte = (byte[])cmd.ExecuteScalar();
            }
            return imgByte;
        }
    }
}