using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.DifferentLayout_Database;
using DIU_CPC_BlueDivision.Models;
using Microsoft.AspNet.Identity;

using Excel = Microsoft.Office.Interop.Excel;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ProblemsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // blueSheets folder er index.cshtml a ase (id).
        // Home folder er index.cshtml a ase (SheetName).

        // GET: Problems
        public ActionResult Index(string id_Or_SheetName)
        {
            string U_id = "", str = "", joinSemester = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
                joinSemester = aspNetUsersBusinessLayer.GetJoinSemester(U_id);
            }

            string appPath = "";
            appPath = string.Format("{0}", Request.Url.AbsoluteUri);
            string[] arr = appPath.Split('=');

            try
            {
                int x = Convert.ToInt32(id_Or_SheetName);
            }
            catch (Exception)
            {
                if (joinSemester != arr[1])
                {
                    throw new Exception();
                }
            }

            ProblemsClass pc = new ProblemsClass();

            //---------------
            if(str == "1234_U1")
            {
                int blueSheetId = Convert.ToInt32(arr[1]);
                DateTime dateTime = pc.retriveDateTime(blueSheetId);
                int problemCount = pc.retriveProblem(blueSheetId);
                DateTime now = DateTime.Now;

                BlueSheetNameRetrive blueSheetNameRetrive = new BlueSheetNameRetrive();
                string blueSheetName = blueSheetNameRetrive.getBlueSheetName(blueSheetId);

                List<Student> students1 = new List<Student>();
                if (now > dateTime)
                {
                    ListOfAllBlueSheetStudents listOfAllBlueSheetStudents = new ListOfAllBlueSheetStudents();

                    students1 = db.Students.Where(per => per.Semester == blueSheetName && per.SolveCount < problemCount).ToList();
                    ViewBag.student = students1;
                    //listOfAllBlueSheetStudents.DeleteStudents();
                }
                else
                {
                    ListOfAllBlueSheetStudents listOfAllBlueSheetStudents = new ListOfAllBlueSheetStudents();
                    students1 = db.Students.Where(per => per.Semester == blueSheetName).ToList();
                    ViewBag.student = students1;
                }
            }
            else
            {
                BlueSheetNameRetrive blueSheetNameRetrive = new BlueSheetNameRetrive();
                int blueSheetId = blueSheetNameRetrive.getBlueSheetId(arr[1]);
                DateTime dateTime = pc.retriveDateTime(blueSheetId);
                int problemCount = pc.retriveProblem(blueSheetId);
                DateTime now = DateTime.Now;

                string blueSheetName = arr[1];

                List<Student> students1 = new List<Student>();
                if (now > dateTime)
                {
                    ListOfAllBlueSheetStudents listOfAllBlueSheetStudents = new ListOfAllBlueSheetStudents();

                    students1 = db.Students.Where(per => per.Semester == blueSheetName && per.SolveCount < problemCount).ToList();
                    ViewBag.student = students1;
                    //listOfAllBlueSheetStudents.DeleteStudents();
                }
                else
                {
                    ListOfAllBlueSheetStudents listOfAllBlueSheetStudents = new ListOfAllBlueSheetStudents();
                    students1 = db.Students.Where(per => per.Semester == blueSheetName).ToList();
                    ViewBag.student = students1;
                }
            }

            
            //---------------

            if (str != "1234_U1")
            {
                bool check = true;
                try
                {
                    int x = Convert.ToInt32(id_Or_SheetName);
                    check = false;
                    throw new Exception();
                }
                catch (Exception)
                {

                }

                if (check)
                {
                    List<Problem> problems = db.Problems.Where(per => per.BlueSheet.BlueSheetName == id_Or_SheetName).ToList();
                    BlueSheet blueSheet = db.BlueSheets.FirstOrDefault(per => per.BlueSheetName == id_Or_SheetName);
                    pc.updateProblemsForSolveCount("Accepted", blueSheet.Id);
                    {
                        //foreach (Problem p in problems)
                        //{
                        //    int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == p.Id && per.IsSolved == "Accepted").ToList().Count;
                        //    pc.updateProblemSolverCount(p.Id, problemCount);
                        //}
                    }
                    return View(problems);
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                int id = Convert.ToInt32(id_Or_SheetName);
                List<BlueSheet> blueSheets = db.BlueSheets.Where(per => per.Id == id).ToList();
                if (blueSheets.Count != 0)
                {
                    List<Problem> problems = db.Problems.Where(per => per.BlueSheetId == id).ToList();

                    pc.updateProblemsForSolveCount("Accepted", id);
                    {
                        //foreach (Problem p in problems)
                        //{
                        //    int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == p.Id && per.IsSolved == "Accepted").ToList().Count;
                        //    pc.updateProblemSolverCount(p.Id, problemCount);
                        //}
                    }
                    return View(problems);
                }
                else
                {
                    throw new Exception();
                }
            }

        }

        // GET: Problems/Details/5
        public ActionResult Details(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // GET: Problems/Create
        public ActionResult Create(int? blueSheetId)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            ViewBag.BlueSheetId = new SelectList(db.BlueSheets.Where(per => per.Id == blueSheetId), "Id", "BlueSheetName");
            return View();
        }

        // POST: Problems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProblemName,ProblemLink,ProblemSolverCount,Comment,BlueSheetId")] Problem problem)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            if (ModelState.IsValid)
            {
                db.Problems.Add(problem);
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = problem.BlueSheetId });
            }

            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // GET: Problems/Edit/5
        public ActionResult Edit(int? id, int blueSheetId)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            //ViewBag.BlueSheetId = new SelectList(db.BlueSheets.Where(per => per.Id == blueSheetId), "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // POST: Problems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProblemName,ProblemLink,ProblemSolverCount,Comment")] Problem problem)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            ProblemsClass prob = new ProblemsClass();
            int id = prob.BlueSheetIdRetrive(problem.Id);
            problem.BlueSheetId = id;

            if (ModelState.IsValid)
            {
                db.Entry(problem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = problem.BlueSheetId });
            }
            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // GET: Problems/Delete/5
        public ActionResult Delete(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // POST: Problems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteProblemsStudents(id);

            Problem problem = db.Problems.Find(id);
            int? Id = problem.BlueSheetId;
            db.Problems.Remove(problem);
            db.SaveChanges();
            return RedirectToAction("Index", "Problems", new { id_Or_SheetName = Id });
        }

        [HttpPost]
        public ActionResult InputFromExcelFile(int blueSheetId, HttpPostedFileBase excelfile)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            string path = Server.MapPath("~/Excel_Files/" + excelfile.FileName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            excelfile.SaveAs(path);

            // read data from excel file

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            Excel.Range range = worksheet.UsedRange;

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                Problem problem = new Problem();
                problem.ProblemName = ((Excel.Range)range.Cells[row, 1]).Text;
                problem.ProblemLink = ((Excel.Range)range.Cells[row, 2]).Text;
                problem.Comment = ((Excel.Range)range.Cells[row, 3]).Text;
                problem.BlueSheetId = blueSheetId;
                db.Problems.Add(problem);
            }
            db.SaveChanges();
            application.Workbooks.Close();

            System.IO.File.Delete(path);
            return RedirectToAction("Index", "Problems", new { id_Or_SheetName = blueSheetId });

        }

        [HttpPost]
        [Route("Controllers/Problems/setDayAndProblem")]
        public void setDayAndProblem(int setDay, int setProblem, int blueSheetId)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update DayAndProblemSet set SetDay = @setDay, SetProblem = @setProblem, [Date] = DATEADD(MINUTE, @setDay, getDate()) where BlueSheetId = @blueSheetId";
                cmd.Parameters.AddWithValue("@setDay", setDay);
                cmd.Parameters.AddWithValue("@setProblem", setProblem);
                cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                cmd.ExecuteNonQuery();

                //ProblemsClass p1 = new ProblemsClass();

                //if (p1.retriveCount(blueSheetId) == 1)
                //{
                //    cmd.CommandText = "update DayAndProblemSet set SetDay = @setDay, SetProblem = @setProblem, [Date] = DATEADD(MINUTE, @setDay, getDate()) where BlueSheetId = @blueSheetId";
                //    cmd.Parameters.AddWithValue("@setDay", setDay);
                //    cmd.Parameters.AddWithValue("@setProblem", setProblem);
                //    cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                //    cmd.ExecuteNonQuery();
                //}
                //else
                //{
                //    cmd.CommandText = "insert into DayAndProblemSet values(@setDay, @setProblem, DATEADD(MINUTE, @setDay, getDate()), @blueSheetId )";
                //    cmd.Parameters.AddWithValue("@setDay", setDay);
                //    cmd.Parameters.AddWithValue("@setProblem", setProblem);
                //    cmd.Parameters.AddWithValue("@blueSheetId", blueSheetId);
                //    cmd.ExecuteNonQuery();
                //}
            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
