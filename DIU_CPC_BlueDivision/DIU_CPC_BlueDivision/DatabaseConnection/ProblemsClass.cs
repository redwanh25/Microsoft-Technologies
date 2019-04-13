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
        //public void updateProblemSolverCount(int problemId, int problemCount)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = con;
        //        con.Open();

        //        cmd.CommandText = "update problems set problemSolverCount = @problemCount where id = @problemId";
        //        cmd.Parameters.AddWithValue("@problemCount", problemCount);
        //        cmd.Parameters.AddWithValue("@problemId", problemId);

        //        cmd.ExecuteNonQuery();
        //    }
        //}

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

        public int BlueSheetIdRetrive(int problemId)
        {
            int Id;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select BlueSheetId from problems where Id = @problemId";
                cmd.Parameters.AddWithValue("@problemId", problemId);

                Id = (int)cmd.ExecuteScalar();
            }
            return Id;
        }

        public int retriveDay(int blueSheetId)
        {
            int day = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select SetDay from DayAndProblemSet where BlueSheetId = @blueSheetId";
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                day = (int)cmd.ExecuteScalar();               
            }
            return day;
        }

        public int retriveCount(int blueSheetId)
        {
            int count = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select count(*) from DayAndProblemSet where BlueSheetId = @blueSheetId";
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        public int retriveProblem(int blueSheetId)
        {
            int problem = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select SetProblem from DayAndProblemSet where BlueSheetId = @blueSheetId";
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                problem = (int)cmd.ExecuteScalar();
            }
            return problem;
        }

        public DateTime retriveDateTime(int blueSheetId)
        {
            DateTime dateTime;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "select [Date] from DayAndProblemSet where BlueSheetId = @blueSheetId";
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                dateTime = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            return dateTime;
        }

        public void insertCutOffStudents(string UserId, string UserName, string Semester, int? SolveCount, string EmailAddress)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "insert into CutOffStudents (UserId, UserName, EmailAddress, Semester, SolveCount) values(@UserId, @UserName, @EmailAddress, @Semester, @SolveCount)";
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@SolveCount", SolveCount);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCutOffStudents(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from CutOffStudents where id = @parameter";
                cmd.Parameters.AddWithValue("@parameter", id);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string CheckUploadFromWhere(int id)
        {
            string str = "";
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select uploadFromWhere from dbo.Problems where  id = @parameter";
                cmd.Parameters.AddWithValue("@parameter", id);
                cmd.Connection = con;

                con.Open();
                if (!string.IsNullOrEmpty(cmd.ExecuteScalar().ToString()))
                {
                    str += (string)cmd.ExecuteScalar();
                }   
            }
            return str;
        }
    }
}