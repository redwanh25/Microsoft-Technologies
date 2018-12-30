using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Software_Company_WebApplication.DatabaseConnection
{
    public class EmployeeImageContains
    {
        public bool hasImage(string str)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select EmployeeImage from EmployeeInformation where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                if (cmd.ExecuteScalar() == null)
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
            byte[] imgByte = new byte[byte.MaxValue-2];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select EmployeeImage from EmployeeInformation where id = @str";
                cmd.Parameters.AddWithValue("@str", str);
                imgByte = (byte[])cmd.ExecuteScalar();
            }
            return imgByte;
        }
    }
}