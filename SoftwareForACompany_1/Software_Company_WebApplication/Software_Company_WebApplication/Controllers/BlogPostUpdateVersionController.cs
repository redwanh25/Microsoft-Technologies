using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_WebApplication.Models;
using Software_Company_WebApplication.DatabaseConnection;

namespace Software_Company_WebApplication.Controllers
{
    public class BlogPostUpdateVersionController : Controller
    {
        private Software_CompanyDBEntities1 db = new Software_CompanyDBEntities1();

        // GET: BlogPostUpdateVersion
        public ActionResult Index()
        {
            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        // GET: BlogPostUpdateVersion/Details/5
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

        // GET: BlogPostUpdateVersion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostUpdateVersion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]  //To Remove A potentially dangerous Request.Form value the client (akhun textarea er vitore html tag use kora jabe)
        public ActionResult Create([Bind(Include = "Id,Title,BlogImage,Text")] Blog_tbl blog_tbl, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    blog_tbl.BlogImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(blog_tbl.BlogImage, 0, image1.ContentLength);
                }
                blog_tbl.Date = DateTime.Now;

                BlogDivIdClass bdi = new BlogDivIdClass();
                int id = bdi.BlogDivIdValue();

                blog_tbl.BlogDivId = "BlogDivId_" + id.ToString();

                db.Blog_tbl.Add(blog_tbl);
                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (DbEntityValidationException e)
                //{
                //    Console.WriteLine(e);
                //}
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog_tbl);
        }

        // GET: BlogPostUpdateVersion/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: BlogPostUpdateVersion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]  //To Remove A potentially dangerous Request.Form value the client (akhun textarea er vitore html tag use kora jabe)
        public ActionResult Edit([Bind(Include = "Id,Title,BlogImage,Text")] Blog_tbl blog_tbl, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    blog_tbl.BlogImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(blog_tbl.BlogImage, 0, image1.ContentLength);
                }
                blog_tbl.Date = DateTime.Now;
                db.Entry(blog_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog_tbl);
        }

        // GET: BlogPostUpdateVersion/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: BlogPostUpdateVersion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            db.Blog_tbl.Remove(blog_tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
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
