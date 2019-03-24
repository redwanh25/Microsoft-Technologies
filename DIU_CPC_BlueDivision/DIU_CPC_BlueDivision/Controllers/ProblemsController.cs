using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            string U_id = "",  str = "", joinSemester = "";
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
                    //foreach (Problem p in problems)
                    //{
                    //    int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == p.Id && per.IsSolved == "Accepted").ToList().Count;
                    //    pc.updateProblemSolverCount(p.Id, problemCount);
                    //}
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
                List<Problem> problems = db.Problems.Where(per => per.BlueSheetId == id).ToList();

                pc.updateProblemsForSolveCount("Accepted", id);
                //foreach (Problem p in problems)
                //{
                //    int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == p.Id && per.IsSolved == "Accepted").ToList().Count;
                //    pc.updateProblemSolverCount(p.Id, problemCount);
                //}
                return View(problems);
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
