using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QRCodeGenerator_AudioVideoImage.DatabaseConnection
{
    public class QRCodeString
    {
        public void storeData(byte[] QRCodeImage, string QRCodeString)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "insert into QRCodeString_tbl values(getdate(), @QRCodeImage, @QRCodeString)";
                cmd.Parameters.AddWithValue("@QRCodeImage", QRCodeImage);
                cmd.Parameters.AddWithValue("@QRCodeString", QRCodeString);

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

                cmd.CommandText = "delete from QRCodeString_tbl where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}