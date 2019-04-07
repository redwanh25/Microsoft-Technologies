using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WorkingWithZipFiles.DatabaseConnection
{
    public class ConnectionWithDatabase
    {
        public void storeData(byte[] ZipFile, string ZipFileName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "insert into ZipFileStorAndDownload_tbl values(getdate(), @ZipFile, @ZipFileName)";
                cmd.Parameters.AddWithValue("@ZipFile", ZipFile);
                cmd.Parameters.AddWithValue("@ZipFileName", ZipFileName);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteData(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "delete from ZipFileStorAndDownload_tbl where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}