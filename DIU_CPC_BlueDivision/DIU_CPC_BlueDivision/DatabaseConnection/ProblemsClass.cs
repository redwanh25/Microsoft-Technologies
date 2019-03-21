using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class ProblemsClass
    {
        public void updateProblemSolverCount(int problemId, int problemCount)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update problems set problemSolverCount = @problemCount where id = @problemId";
                cmd.Parameters.AddWithValue("@problemCount", problemCount);
                cmd.Parameters.AddWithValue("@problemId", problemId);

                cmd.ExecuteNonQuery();
            }
        }

        public void updateProblemsForSolveCount(string isSolved, int blueSheetId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "solveCountForProblems_Procedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@isSolved", isSolved);
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);

                cmd.ExecuteReader();
            }
        }
    }
}