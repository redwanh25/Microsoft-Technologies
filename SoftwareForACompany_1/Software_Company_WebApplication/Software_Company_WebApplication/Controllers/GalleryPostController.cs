using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_WebApplication.Models;

namespace Software_Company_WebApplication.Controllers
{
    public class GalleryPostController : Controller
    {
        private Software_CompanyDBEntities2 db = new Software_CompanyDBEntities2();

        // GET: GalleryPost
        public ActionResult Index()
        {
            List<Gallery_tbl> list = db.Gallery_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        // GET: GalleryPost/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_tbl gallery_tbl = db.Gallery_tbl.Find(id);
            if (gallery_tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_tbl);
        }

        // GET: GalleryPost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GalleryPost/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GalleryImage")] Gallery_tbl gallery_tbl, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    try
                    {
                        gallery_tbl.GalleryImage = new byte[image1.ContentLength];
                        image1.InputStream.Read(gallery_tbl.GalleryImage, 0, image1.ContentLength);
                        //ViewBag.Message = "File uploaded successfully";                      
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    }

                    db.Gallery_tbl.Add(gallery_tbl);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "The Gallery Image field is required.";
                }
            }

            return View(gallery_tbl);
        }

        // GET: GalleryPost/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_tbl gallery_tbl = db.Gallery_tbl.Find(id);
            if (gallery_tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_tbl);
        }

        // POST: GalleryPost/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GalleryImage")] Gallery_tbl gallery_tbl, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    try
                    {
                        gallery_tbl.GalleryImage = new byte[image1.ContentLength];
                        image1.InputStream.Read(gallery_tbl.GalleryImage, 0, image1.ContentLength);
                        //ViewBag.Message = "File uploaded successfully";                      
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    }

                    db.Gallery_tbl.Add(gallery_tbl);
                    db.Entry(gallery_tbl).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "The Gallery Image field is required.";
                }
            }
            return View(gallery_tbl);
        }

        // GET: GalleryPost/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_tbl gallery_tbl = db.Gallery_tbl.Find(id);
            if (gallery_tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_tbl);
        }

        // POST: GalleryPost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gallery_tbl gallery_tbl = db.Gallery_tbl.Find(id);
            db.Gallery_tbl.Remove(gallery_tbl);
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
