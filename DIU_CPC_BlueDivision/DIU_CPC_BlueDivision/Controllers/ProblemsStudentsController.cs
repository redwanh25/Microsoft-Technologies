using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.DifferentLayout_Database;
using DIU_CPC_BlueDivision.Models;
using Microsoft.AspNet.Identity;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ProblemsStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();
        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();

        // GET: ProblemsStudents
        [NonAction]
        public ActionResult Index()
        {
            var problemsStudents = db.ProblemsStudents.Include(p => p.Problem).Include(p => p.Student);
            return View(problemsStudents.ToList());
        }

        // GET: ProblemsStudents/Details/5
        [NonAction]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProblemsStudent problemsStudent = db.ProblemsStudents.Find(id);
            if (problemsStudent == null)
            {
                return HttpNotFound();
            }
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Create
        [NonAction]
        public ActionResult Create(int problemId, string userName)
        {
            //ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName");
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName");

            List<ProblemsStudent> problemsStudents = db.ProblemsStudents.Where(per => per.ProblemId == problemId && per.Student.UserName == userName).ToList();
            if (problemsStudents.Count != 0)
            {
                throw new Exception();
            }

            string U_id = "", str = "", joinSemester = "", userName1 = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
                joinSemester = aspNetUsersBusinessLayer.GetJoinSemester(U_id);
                userName1 = aspNetUsersBusinessLayer.GetUserName(U_id);
            }
            if (str == student)
            {
                if (userName1 == userName)
                {

                    ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
                    string check = listOfAllAdminsAndStudents.CheckMuteOrUnmute(U_id);

                    if (check == "Mute")
                    {
                        throw new Exception();
                    }

                    List<Problem> problem = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSemester).ToList();
                    foreach (Problem p in problem)
                    {
                        if (p.Id == problemId)
                        {
                            //ViewBag.ProblemId = new SelectList(db.Problems.Where(per => per.Id == problemId), "Id", "ProblemName");
                            //ViewBag.StudentId = new SelectList(db.Students.Where(per => per.UserName == userName), "Id", "UserName");
                            return View();
                        }
                    }
                    throw new Exception();
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new Exception();
            }

        }

        // POST: ProblemsStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] [NonAction]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Comment,IsSolved,SolutionLink,ShareSolutionLink")] ProblemsStudent problemsStudent)
        {
            string userId = "", joinSem = "";
            userId = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(userId))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                joinSem = aspNetUsersBusinessLayer.GetJoinSemester(userId);
            }

            string U_id = "", str = "", joinSemester = "", userName1 = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
                joinSemester = aspNetUsersBusinessLayer.GetJoinSemester(U_id);
                userName1 = aspNetUsersBusinessLayer.GetUserName(U_id);
            }

            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            string check = listOfAllAdminsAndStudents.CheckMuteOrUnmute(U_id);

            if (check == "Mute")
            {
                throw new Exception();
            }

            List<Problem> problem = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSemester).ToList();

            string appPath = "";
            appPath = string.Format("{0}", Request.Url.AbsoluteUri);
            string[] arr = appPath.Split('=');
            string arr1 = arr[1];
            string[] arr2 = arr1.Split('&');
            int probId = Convert.ToInt32(arr2[0]);

            problemsStudent.ProblemId = probId;
            problemsStudent.StudentId = userId;
            if (ModelState.IsValid)
            {
                db.ProblemsStudents.Add(problemsStudent);
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = joinSem });
            }

            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Edit/5
        [NonAction]
        public ActionResult Edit(int problemId, string userName)
        {
            string U_id = "", str = "", joinSemester = "", userName1 = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
                joinSemester = aspNetUsersBusinessLayer.GetJoinSemester(U_id);
                userName1 = aspNetUsersBusinessLayer.GetUserName(U_id);
            }
            if (str == student)
            {
                if (userName1 == userName)
                {
                    ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
                    string check = listOfAllAdminsAndStudents.CheckMuteOrUnmute(U_id);

                    if (check == "Mute")
                    {
                        throw new Exception();
                    }

                    List<Problem> problem = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSemester).ToList();
                    foreach (Problem p in problem)
                    {
                        if (p.Id == problemId)
                        {
                            if (db.ProblemsStudents.FirstOrDefault(per => per.Problem.Id == problemId && per.Student.UserName == userName) == null)
                            {
                                return RedirectToAction("Create", "ProblemsStudents", new { problemId, userName });
                                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                            }
                            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.Problem.Id == problemId && per.Student.UserName == userName);
                            if (problemsStudent == null)
                            {
                                return HttpNotFound();
                            }
                            ViewBag.ProblemId = new SelectList(db.Problems.Where(per => per.Id == problemId), "Id", "ProblemName", problemsStudent.ProblemId);
                            ViewBag.StudentId = new SelectList(db.Students.Where(per => per.UserName == userName), "Id", "UserName", problemsStudent.StudentId);
                            return View(problemsStudent);
                        }
                    }
                    throw new Exception();
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new Exception();
            }
        }

        // POST: ProblemsStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Comment,IsSolved,SolutionLink,ShareSolutionLink,ProblemId,StudentId")] ProblemsStudent problemsStudent)
        //{
        //    string userId = "", joinSem = "";
        //    userId = User.Identity.GetUserId();

        //    if (!string.IsNullOrEmpty(userId))
        //    {
        //        AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
        //        joinSem = aspNetUsersBusinessLayer.GetJoinSemester(userId);
        //    }

        //    ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
        //    string check = listOfAllAdminsAndStudents.CheckMuteOrUnmute(userId);

        //    if (check == "Mute")
        //    {
        //        throw new Exception();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(problemsStudent).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index", "Problems", new { id_Or_SheetName = joinSem });
        //    }
        //    ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
        //    ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
        //    return View(problemsStudent);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IEnumerable<int> verdict)
        {
            string userId = "", joinSem = "", userName = "";
            userId = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(userId))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                joinSem = aspNetUsersBusinessLayer.GetJoinSemester(userId);
                userName = aspNetUsersBusinessLayer.GetUserName(userId);
            }

            List<Problem> problem = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSem).ToList();
            ProblemsStudentsClass psc = new ProblemsStudentsClass();
            foreach (Problem prob in problem)
            {
                if (db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == prob.Id && per.StudentId == userId) != null)
                {
                    psc.UpdateData(prob.Id, userId, "");
                }
            }

            if (verdict != null)
            {
                List<int> list = verdict.ToList();
                foreach (int problemId in list)
                {
                    if (db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == problemId && per.StudentId == userId) == null)
                    {
                        ProblemsStudent problemsStudent = new ProblemsStudent();
                        problemsStudent.ProblemId = problemId;
                        problemsStudent.StudentId = userId;
                        problemsStudent.IsSolved = "Accepted";
                        problemsStudent.SubmitDate = DateTime.UtcNow.AddHours(+6);

                        db.ProblemsStudents.Add(problemsStudent);
                        db.SaveChanges();
                    }
                    else
                    {
                        psc.UpdateData(problemId, userId, "Accepted");
                    }
                }
            }
            ProblemsClass pc = new ProblemsClass();
            List<Problem> problems = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSem).ToList();
            BlueSheet blueSheet = db.BlueSheets.FirstOrDefault(per => per.BlueSheetName == joinSem);
            pc.updateProblemsForSolveCount("Accepted", blueSheet.Id);


            return RedirectToAction("Index", "Problems", new { id_Or_SheetName = joinSem });
        }

        // GET: ProblemsStudents/Delete/5
        [NonAction]
        public ActionResult Delete(int? problemId, string studentId)
        {
            if (problemId == null && studentId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == problemId && per.StudentId == studentId);
            if (problemsStudent == null)
            {
                return HttpNotFound();
            }
            return View(problemsStudent);
        }

        // POST: ProblemsStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [NonAction]
        public ActionResult DeleteConfirmed(int? problemId, string studentId)
        {
            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == problemId && per.StudentId == studentId);
            db.ProblemsStudents.Remove(problemsStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [NonAction]
        public ActionResult Solver(int problemId)
        {
            //int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == problemId && per.IsSolved == "Accepted").ToList().Count;
            //ProblemsClass pc = new ProblemsClass();
            //pc.updateProblemSolverCount(problemId, problemCount);

            string U_id = "", str = "", joinSemester = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
                joinSemester = aspNetUsersBusinessLayer.GetJoinSemester(U_id);
            }
            if (str == student)
            {
                List<Problem> problem = db.Problems.Where(per => per.BlueSheet.BlueSheetName == joinSemester).ToList();
                foreach (Problem p in problem)
                {
                    if (p.Id == problemId)
                    {
                        List<ProblemsStudent> problemsStudents = db.ProblemsStudents.Where(per => per.ProblemId == problemId).ToList();   //&& per.IsSolved == "Accepted"
                        return View(problemsStudents);
                    }
                }
                throw new Exception();
            }
            else
            {
                List<ProblemsStudent> problemsStudents = db.ProblemsStudents.Where(per => per.ProblemId == problemId).ToList();   //&& per.IsSolved == "Accepted"
                return View(problemsStudents);
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
