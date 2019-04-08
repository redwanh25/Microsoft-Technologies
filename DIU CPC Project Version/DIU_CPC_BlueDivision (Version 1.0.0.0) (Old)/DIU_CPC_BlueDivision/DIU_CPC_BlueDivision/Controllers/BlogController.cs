using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_CPC_BlueDivision.Models;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class BlogController : Controller
    {
        private BlogPostEntities db = new BlogPostEntities();

        // GET: Blog
        public ActionResult Index()
        {
            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }


        // GET: Blog/Details/5
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

        //// GET: Blog/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Blog/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Title,Date,BlogImage,Text,BlogDivId")] Blog_tbl blog_tbl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Blog_tbl.Add(blog_tbl);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(blog_tbl);
        //}

        //// GET: Blog/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
        //    if (blog_tbl == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(blog_tbl);
        //}

        //// POST: Blog/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Title,Date,BlogImage,Text,BlogDivId")] Blog_tbl blog_tbl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(blog_tbl).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(blog_tbl);
        //}

        //// GET: Blog/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
        //    if (blog_tbl == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(blog_tbl);
        //}

        //// POST: Blog/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
        //    db.Blog_tbl.Remove(blog_tbl);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
