using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class DeleteDataFromDatabase
    {
        public void deleteBlueSheets(int blueSheetId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete_ProblemsStudentAndProblems_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);

                cmd.ExecuteReader();
            }
        }

        public void deleteProblemsStudents(int problemId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete_ProblemsStudents_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@problemId", problemId);

                cmd.ExecuteReader();
            }
        }

        public void deleteContest(int contestId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete_Contest_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@contestId", contestId);

                cmd.ExecuteReader();
            }
        }

        public void deleteContestant(int contestantId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete_Contestant_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@contestantId", contestantId);

                cmd.ExecuteReader();
            }
        }
    }
}