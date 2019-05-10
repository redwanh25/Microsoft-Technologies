using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class ContestClass
    {
        public int contestId(int id)
        {
            int conId = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select contestId from [dbo].[ContestContestants] where Id = @id";
                cmd.Parameters.AddWithValue("@Id", id);

                conId = (int)cmd.ExecuteScalar();
            }
            return conId;
        }

        public int contestantId(int id)
        {
            int conId = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select contestantId from [dbo].[ContestContestants] where Id = @id";
                cmd.Parameters.AddWithValue("@Id", id);

                conId = (int)cmd.ExecuteScalar();
            }
            return conId;
        }
    }
}