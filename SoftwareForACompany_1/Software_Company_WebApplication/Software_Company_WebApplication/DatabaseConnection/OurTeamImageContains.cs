using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class OurTeamImageContains
    {
        public bool hasImage(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select EmployeeImage from OurTeam where id = @str";
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
        public byte[] EmpImageByte(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            byte[] imgByte = new byte[byte.MaxValue - 2];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select EmployeeImage from OurTeam where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                imgByte = (byte[])cmd.ExecuteScalar();
            }
            return imgByte;
        }
    }
}