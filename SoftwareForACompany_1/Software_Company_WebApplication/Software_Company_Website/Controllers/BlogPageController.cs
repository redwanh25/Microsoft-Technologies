using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class BlogPageController : Controller
    {
        private BlogTableMainPageDBEntities db = new BlogTableMainPageDBEntities();

        // GET: BlogPage
        //[OutputCache(Duration = 31536000)]      // save in cache for 1 year
        public ActionResult Index()
        {
            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        // GET: BlogPage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }
            return View(blog_tbl);
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
