﻿using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.DifferentLayout_Database;
using DIU_CPC_BlueDivision.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class BluesheetExcelFormatViewController : Controller
    {
        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();

        // GET: BluesheetExcelFormatView
        public ActionResult Index(string semester)
        {
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
                if (string.IsNullOrEmpty(semester))
                {
                    ProblemSolvingRanking problemSolvingRanking1 = new ProblemSolvingRanking();
                    problemSolvingRanking1.updateStudentsForSolveCount("Accepted", joinSemester);
                    ViewBag.semester = joinSemester;
                }
                else
                {
                    throw new Exception();
                }
                
            }
            else
            {
                ProblemSolvingRanking problemSolvingRanking = new ProblemSolvingRanking();
                problemSolvingRanking.updateStudentsForSolveCount("Accepted", semester);
                ViewBag.semester = semester;
            }

            BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();
            Blue_Prob_ProbStu_Stu blue_Prob_ProbStu_Stu = new Blue_Prob_ProbStu_Stu();
            blue_Prob_ProbStu_Stu.blueSheets = db.BlueSheets.ToList();
            blue_Prob_ProbStu_Stu.problems = db.Problems.ToList();
            blue_Prob_ProbStu_Stu.problemsStudents = db.ProblemsStudents.ToList();
            blue_Prob_ProbStu_Stu.students = db.Students.ToList();

            return View(blue_Prob_ProbStu_Stu);
        }
    }
}