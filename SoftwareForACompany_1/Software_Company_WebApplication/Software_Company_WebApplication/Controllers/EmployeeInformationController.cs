using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Software_Company_WebApplication.DatabaseConnection;
using Software_Company_WebApplication.Models;

namespace Software_Company_WebApplication.Controllers
{
    public class EmployeeInformationController : Controller
    {
        private DBEntities_EmployeeInformation db = new DBEntities_EmployeeInformation();

        // GET: EmployeeInformation
        public ActionResult Index()
        {
            string LogingUserId = User.Identity.GetUserId();
            List<EmployeeInformation> list = db.EmployeeInformations.ToList();
            List<EmployeeInformation> LoginUser = new List<EmployeeInformation>();
            foreach(EmployeeInformation emp in list)
            {
                if (emp.Id.Equals(LogingUserId))
                {
                    LoginUser.Add(emp);
                }
            }          
            return View(LoginUser);
        }

        // GET: EmployeeInformation/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInformation employeeInformation = db.EmployeeInformations.Find(id);
            if (employeeInformation == null)
            {
                return HttpNotFound();
            }
            return View(employeeInformation);
        }

        // POST: EmployeeInformation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PhoneNumber,Address,EmployeeImage,DateOfBirth,FullName,Gender,MaritalStatus,BloodGroup,Religion,Nationality,AboutYou,AlternativeEmail,PostOffice,District,Country,ZipCode,PassportNo,Designation,JobExperience")] EmployeeInformation employeeInformation, HttpPostedFileBase image1)
        {
            
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    employeeInformation.EmployeeImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(employeeInformation.EmployeeImage, 0, image1.ContentLength);
                }
                EmailAndUserName_Retrive eu = new EmailAndUserName_Retrive();
                employeeInformation.UserName = eu.GetUserName(employeeInformation.Id);
                employeeInformation.Email = eu.GetEmailId(employeeInformation.Id);

                //var dateAndTime = Convert.ToDateTime(employeeInformation.DateOfBirth);
                //employeeInformation.DateOfBirth = dateAndTime.ToString("dd/MM/yyyy");

                EmployeeImageContains hasImg = new EmployeeImageContains();
                bool img = hasImg.hasImage(employeeInformation.Id);
                if(image1 == null && img == true)
                {
                    byte[] imgArr = hasImg.EmpImageByte(employeeInformation.Id);
                    image1 = new MemoryPostedFile(imgArr);

                    employeeInformation.EmployeeImage = new byte[image1.ContentLength];
                    image1.InputStream.Read(employeeInformation.EmployeeImage, 0, image1.ContentLength);
                }

                db.Entry(employeeInformation).State = EntityState.Modified;


                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeInformation);
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
