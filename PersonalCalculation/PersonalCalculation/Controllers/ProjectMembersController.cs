using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonalCalculation.DatabaseConnection;
using PersonalCalculation.Models;

namespace PersonalCalculation.Controllers
{
    public class ProjectMembersController : Controller
    {
        private PersonalCalculationDBEntities db = new PersonalCalculationDBEntities();

        // GET: ProjectMembers
        public ActionResult Index(int projId)
        {
            ShareByCalculation(projId);
            UpdateData updateData = new UpdateData();
            updateData.UpdateDueMoney(projId);

            var projectMembers = db.ProjectMembers.Where(per => per.ProjectId == projId);
            ViewBag.ProjectId = projId;
            return View(projectMembers.ToList());
        }

        // GET: ProjectMembers/Details/5
        public ActionResult Details(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectMember projectMember = db.ProjectMembers.Find(id);
            if (projectMember == null)
            {
                return HttpNotFound();
            }
            return View(projectMember);
        }

        // GET: ProjectMembers/Create
        public ActionResult Create(int projId)
        { 
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName");
            return View();
        }

        // POST: ProjectMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PartnerName,SpendMoney,DueMoney,ShareBy,ProjectId")] ProjectMember projectMember)
        {
            if (ModelState.IsValid)
            {
                //if (string.IsNullOrEmpty(projectMember.SpendMoney.ToString()))
                //{
                //    projectMember.SpendMoney = 0;
                //}
                db.ProjectMembers.Add(projectMember);
                db.SaveChanges();
                return RedirectToAction("Index", "ProjectMembers", new { projId = projectMember.ProjectId });
            }

            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", projectMember.ProjectId);
            return View(projectMember);
        }

        // GET: ProjectMembers/Edit/5
        public ActionResult Edit(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectMember projectMember = db.ProjectMembers.Find(id);
            if (projectMember == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectId = projectMember.ProjectId;
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName", projectMember.ProjectId);
            return View(projectMember);
        }

        // POST: ProjectMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PartnerName,SpendMoney,DueMoney,ShareBy,ProjectId")] ProjectMember projectMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "ProjectMembers", new { projId = projectMember.ProjectId });
            }
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", projectMember.ProjectId);
            return View(projectMember);
        }

        // GET: ProjectMembers/Delete/5
        public ActionResult Delete(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectMember projectMember = db.ProjectMembers.Find(id);
            if (projectMember == null)
            {
                return HttpNotFound();
            }
            return View(projectMember);
        }

        // POST: ProjectMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectMember projectMember = db.ProjectMembers.Find(id);
            int proId = Convert.ToInt32(projectMember.ProjectId);
            db.ProjectMembers.Remove(projectMember);
            db.SaveChanges();
            return RedirectToAction("Index", "ProjectMembers", new { projId = proId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        void ShareByCalculation(int projId)
        {
            Project project = db.Projects.FirstOrDefault(per => per.Id == projId);
            int count = db.ProjectMembers.Where(per => per.ProjectId == projId).Count();
            if(count != 0)
            {
                decimal ShareBy = Convert.ToDecimal(project.Invest / count);

                UpdateData updateData = new UpdateData();
                updateData.UpdateShareBy(ShareBy, projId);
            }
            
        }
    }
}
