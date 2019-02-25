using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Software_Company_WebApplication.DatabaseConnection;
using Software_Company_WebApplication.DifferentLayout_Database;
using Software_Company_WebApplication.Models;

namespace Software_Company_WebApplication.Controllers
{
    public class OurTeamsController : Controller
    {
        private OurTeamDBEntities db = new OurTeamDBEntities();
        // GET: OurTeams
        public ActionResult Index()
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }

            List<OurTeam> list = db.OurTeams.ToList();
            list = list.OrderByDescending(it => it.Id).ToList();
            return View(list);
        }

        // GET: OurTeams/Details/5
        public ActionResult Details(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurTeam ourTeam = db.OurTeams.Find(id);
            if (ourTeam == null)
            {
                return HttpNotFound();
            }
            return View(ourTeam);
        }

        // GET: OurTeams/Create
        public ActionResult Create()
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            return View();
        }

        // POST: OurTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Designation,WorkingSince,EmployeeImage")] OurTeam ourTeam, HttpPostedFileBase image1)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    ourTeam.EmployeeImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(ourTeam.EmployeeImage, 0, image1.ContentLength);
                }
                db.OurTeams.Add(ourTeam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ourTeam);
        }

        // GET: OurTeams/Edit/5
        public ActionResult Edit(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurTeam ourTeam = db.OurTeams.Find(id);
            if (ourTeam == null)
            {
                return HttpNotFound();
            }
            return View(ourTeam);
        }

        // POST: OurTeams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Designation,WorkingSince,EmployeeImage")] OurTeam ourTeam, HttpPostedFileBase image1)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    ourTeam.EmployeeImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(ourTeam.EmployeeImage, 0, image1.ContentLength);
                }

                OurTeamImageContains hasImg = new OurTeamImageContains();

                bool img = hasImg.hasImage(ourTeam.Id.ToString());
                if (image1 == null && img == true)
                {
                    byte[] imgArr = hasImg.EmpImageByte(ourTeam.Id.ToString());
                    image1 = new MemoryPostedFile(imgArr);

                    ourTeam.EmployeeImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(ourTeam.EmployeeImage, 0, image1.ContentLength);
                }

                db.Entry(ourTeam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ourTeam);
        }

        //// GET: OurTeams/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    OurTeam ourTeam = db.OurTeams.Find(id);
        //    if (ourTeam == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ourTeam);
        //}

        //// POST: OurTeams/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    OurTeam ourTeam = db.OurTeams.Find(id);
        //    db.OurTeams.Remove(ourTeam);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult RemoveTeamPicture(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurTeam ourTeams = db.OurTeams.Find(id);
            if (ourTeams == null)
            {
                return HttpNotFound();
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update OurTeam set [EmployeeImage] = null where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            string str1 = "Edit/" + id;
            return RedirectToAction(str1);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetEmployeeCode(str);
            }
            if (str != "1234_U2")
            {
                return HttpNotFound();
            }
            OurTeam ourTeam = db.OurTeams.Find(id);
            db.OurTeams.Remove(ourTeam);
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
