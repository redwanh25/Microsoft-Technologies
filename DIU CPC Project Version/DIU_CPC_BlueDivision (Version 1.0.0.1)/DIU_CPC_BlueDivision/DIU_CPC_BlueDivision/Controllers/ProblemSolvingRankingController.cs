using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ProblemSolvingRankingController : Controller
    {
        // GET: ProblemSolvingRanking
        [NonAction]
        public ActionResult Index(string semester)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter cmd = new SqlDataAdapter("select S.UserName, count(*) as SolveCount, S.Semester as JoiningSemester into #TempTable " +
                        "from Students S, ProblemsStudents PS where PS.StudentId = S.Id and PS.IsSolved = @isSolved and S.Semester = @semester " +
                        "group by S.UserName, S.Semester select * from #TempTable order by SolveCount desc drop table #TempTable", con);

                    cmd.SelectCommand.Parameters.AddWithValue("@isSolved", "Accepted");
                    cmd.SelectCommand.Parameters.AddWithValue("@semester", semester);
                    cmd.Fill(dt);
                }
                catch(Exception ex)
                {
                    throw new Exception();
                }
            }
            return View(dt);
        }
    }
}