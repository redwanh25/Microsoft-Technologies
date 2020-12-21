using RND.AdoDotNetCode;
using RND.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RND.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            Session["StartId"] = 1;
            Session["EndId"] = 100;
            return View();
        }

        [HttpPost]
        public ActionResult FindByDate(int startId, int endId)
        {
            Session["StartId"] = startId;
            Session["EndId"] = endId;
            return Json(new { x = "success"});
        }

        public ActionResult ListOfEmployee(JqueryDatatableParam param)
        {
            int startId = (int)Session["StartId"];
            int endId = (int)Session["EndId"];
            var employees = EmployeeClass.GetAllEmployee().Where(x => x.Id >= startId && x.Id <= endId);

            if (!string.IsNullOrEmpty(param.sSearch))
            {
                employees = employees.Where(x => x.Id.ToString().Contains(param.sSearch.ToLower())
                                              || x.Name.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Gender.ToLower().Contains(param.sSearch.ToLower())
                                              || x.Salary.ToString().Contains(param.sSearch.ToLower())).ToList();
            }

            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.QueryString["iSortCol_0"]);
            var sortDirection = HttpContext.Request.QueryString["sSortDir_0"];

            if (sortColumnIndex == 0)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Id).ToList() : employees.OrderByDescending(c => c.Id).ToList();
            }
            else if (sortColumnIndex == 1)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Name).ToList() : employees.OrderByDescending(c => c.Name).ToList();
            }
            else if (sortColumnIndex == 2)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Gender).ToList() : employees.OrderByDescending(c => c.Gender).ToList();
            }
            else if (sortColumnIndex == 3)
            {
                employees = sortDirection == "asc" ? employees.OrderBy(c => c.Salary).ToList() : employees.OrderByDescending(c => c.Salary).ToList();
            }

            var displayResult = employees.Skip(param.iDisplayStart).Take(param.iDisplayLength).ToList();
            var totalRecords = employees.Count();

            return Json(new
            {
                param.sEcho,
                iTotalRecords = totalRecords,
                iTotalDisplayRecords = totalRecords,
                aaData = displayResult
            }, JsonRequestBehavior.AllowGet);

        }
    }
}