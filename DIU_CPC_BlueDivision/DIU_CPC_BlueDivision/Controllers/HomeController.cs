using DIU_CPC_BlueDivision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class HomeController : Controller
    {
        BlogPostEntities db = new BlogPostEntities();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).Take(4).ToList();
            return View(list);
        }

        public ActionResult View1()
        {
            ViewBag.Title = "View1";
            return View();
        }

        public ActionResult View2()
        {
            ViewBag.Title = "View2";
            return View();
        }
    }
}
