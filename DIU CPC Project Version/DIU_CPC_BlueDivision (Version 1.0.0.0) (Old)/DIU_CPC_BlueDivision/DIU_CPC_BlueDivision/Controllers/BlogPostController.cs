using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
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
    public class BlogPostController : Controller
    {
        private BlogPostEntities db = new BlogPostEntities();

        // GET: BlogPost
        public ActionResult Index()
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

            List<Blog_tbl> list = db.Blog_tbl.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        // GET: BlogPost/Details/5
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
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }
            return View(blog_tbl);
        }

        // GET: BlogPost/Create
        public ActionResult Create()
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

            return View();
        }

        // POST: BlogPost/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]  //To Remove A potentially dangerous Request.Form value the client (akhun textarea er vitore html tag use kora jabe)
        public ActionResult Create([Bind(Include = "Id,Title,Date,BlogImage,Text,BlogDivId")] Blog_tbl blog_tbl, HttpPostedFileBase image1)
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
                if (image1 != null)
                {
                    blog_tbl.BlogImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(blog_tbl.BlogImage, 0, image1.ContentLength);
                }
                blog_tbl.Date = DateTime.Now;

                //BlogDivIdClass bdi = new BlogDivIdClass();
                //int id = bdi.BlogDivIdValue();

                blog_tbl.BlogDivId = "BlogDivId_" + UniqueIdGenerate();

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

        // GET: BlogPost/Edit/5
        public ActionResult Edit(int? id)
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
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }
            return View(blog_tbl);
        }

        // POST: BlogPost/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]  //To Remove A potentially dangerous Request.Form value the client (akhun textarea er vitore html tag use kora jabe)
        public ActionResult Edit([Bind(Include = "Id,Title,BlogImage,Text")] Blog_tbl blog_tbl, HttpPostedFileBase image1)
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
                if (image1 != null)
                {
                    blog_tbl.BlogImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(blog_tbl.BlogImage, 0, image1.ContentLength);
                }
                blog_tbl.Date = DateTime.Now;

                //BlogDivIdClass bdi = new BlogDivIdClass();
                //int id = bdi.BlogDivIdValue();

                blog_tbl.BlogDivId = "BlogDivId_" + UniqueIdGenerate();

                BlogImageContains hasImg = new BlogImageContains();
                bool img = hasImg.hasImage(blog_tbl.Id);
                if (image1 == null && img == true)
                {
                    byte[] imgArr = hasImg.EmpImageByte(blog_tbl.Id);
                    image1 = new MemoryPostedFile(imgArr);

                    blog_tbl.BlogImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(blog_tbl.BlogImage, 0, image1.ContentLength);
                }

                db.Entry(blog_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog_tbl);
        }

        // GET: BlogPost/Delete/5
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
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }
            return View(blog_tbl);
        }

        // POST: BlogPost/Delete/5
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

            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            db.Blog_tbl.Remove(blog_tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveBlogPicture(int? id)
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
            Blog_tbl blog_tbl = db.Blog_tbl.Find(id);
            if (blog_tbl == null)
            {
                return HttpNotFound();
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update Blog_tbl set [BlogImage] = null where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            string str1 = "Edit/" + id;
            return RedirectToAction(str1);
        }

        public string UniqueIdGenerate()
        {
            byte[] buffer1 = Guid.NewGuid().ToByteArray();
            string number = BitConverter.ToUInt32(buffer1, 8).ToString();
            number += String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            byte[] buffer2 = Guid.NewGuid().ToByteArray();
            number += BitConverter.ToUInt32(buffer2, 8).ToString();
            return number;
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

    public class MemoryPostedFile : HttpPostedFileBase
    {
        private readonly byte[] fileBytes;

        public MemoryPostedFile(byte[] fileBytes, string fileName = null)
        {
            this.fileBytes = fileBytes;
            this.FileName = fileName;
            this.InputStream = new MemoryStream(fileBytes);
        }

        public override int ContentLength => fileBytes.Length;

        public override string FileName { get; }

        public override Stream InputStream { get; }
    }
}
