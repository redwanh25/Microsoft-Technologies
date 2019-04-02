using DIU_CPC_BlueDivision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class BluesheetExcelFormatViewController : Controller
    {
        // GET: BluesheetExcelFormatView
        public ActionResult Index()
        {
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