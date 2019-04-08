using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.DatabaseConnection
{
    public class ProblemsStudentsClass
    {
        public void UpdateData(int ProblemId, string StudentId, string IsSolved)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update ProblemsStudents set IsSolved = @isSolved where ProblemId = @problemId and StudentId = @studentId";
                cmd.Parameters.AddWithValue("@problemId", ProblemId);
                cmd.Parameters.AddWithValue("@studentId", StudentId);
                cmd.Parameters.AddWithValue("@isSolved", IsSolved);

                cmd.ExecuteNonQuery();
            }
        }
    }
}