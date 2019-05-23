using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using InputFromExcelFile.Models;

namespace InputFromExcelFile.Controllers
{
    public class ContestContestantsController : Controller
    {
        private ConConEntities db = new ConConEntities();

        // GET: ContestContestants
        public ActionResult Index()
        {
            var contestContestants = db.ContestContestants.Include(c => c.ContestantsTable).Include(c => c.ContestTable);
            return View(contestContestants.ToList());
        }

        // GET: ContestContestants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            if (contestContestant == null)
            {
                return HttpNotFound();
            }
            return View(contestContestant);
        }

        // GET: ContestContestants/Create
        public ActionResult Create()
        {
            ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName");
            ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName");
            return View();
        }

        // POST: ContestContestants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        {
            if (ModelState.IsValid)
            {
                db.ContestContestants.Add(contestContestant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // GET: ContestContestants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            if (contestContestant == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // POST: ContestContestants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestContestant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // GET: ContestContestants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            if (contestContestant == null)
            {
                return HttpNotFound();
            }
            return View(contestContestant);
        }

        // POST: ContestContestants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            db.ContestContestants.Remove(contestContestant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult InputFromExcelFile(HttpPostedFileBase excelfile)
        {
            string path = Server.MapPath("~/Excel_Files/" + excelfile.FileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            excelfile.SaveAs(path);

            // read data from excel file

            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(path, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                List<Row> rows = sheetData.Descendants<Row>().ToList();

                for (int i = 12; i < rows.Count(); i++)     // start with 0 index
                {
                    ContestTable contestTable = new ContestTable();
                    try
                    {
                        string contestName = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(0));
                        string date = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(1));
                        string numberOfProblems = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(2));
                        string participation = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(3));

                        contestTable.ContestName = contestName;
                        //contestTable.Date = Convert.ToDateTime(date);
                        double d = Convert.ToDouble(numberOfProblems);
                        contestTable.NumberOfProblems = Convert.ToInt32(d);
                        contestTable.Participation = Convert.ToInt32(participation);

                        db.ContestTables.Add(contestTable);
                    }
                    catch (Exception)
                    {
                        //break;
                    }
                }

                for (int col = 5; col < rows[3].Count(); col++)         // start with 0 index
                {
                    ContestantsTable contestantsTable = new ContestantsTable();
                    try
                    {
                        string studentId = GetCellValue(spreadSheetDocument, rows[3].Descendants<Cell>().ElementAt(col));
                        string contestantsName = GetCellValue(spreadSheetDocument, rows[4].Descendants<Cell>().ElementAt(col));
                        string cFHandle = GetCellValue(spreadSheetDocument, rows[5].Descendants<Cell>().ElementAt(col));

                        contestantsTable.ContestantsName = contestantsName;
                        contestantsTable.StudentId = studentId;
                        contestantsTable.CFHandle = cFHandle;

                        db.ContestantsTables.Add(contestantsTable);
                    }
                    catch (Exception)
                    {
                        //break;
                    }
                }
                db.SaveChanges();

                List<ContestantsTable> contestant = db.ContestantsTables.ToList();
                List<ContestTable> contest = db.ContestTables.ToList();
                //for (int i = 0; i < 130; i++)
                //{
                //    ContestContestant contestContestant = new ContestContestant();
                //    string conTimeSol = "", upsolve = "";
                //    try
                //    {
                //        conTimeSol = GetCellValue(spreadSheetDocument, rows[12].Descendants<Cell>().ElementAt(i));
                //        upsolve = GetCellValue(spreadSheetDocument, rows[8].Descendants<Cell>().ElementAt(i));
                //        if(upsolve == "Upsolves")
                //        {
                //            contestContestant.ContestTimeSolve = conTimeSol + "-U-" + i;
                //        }
                //        else
                //        {
                //            contestContestant.ContestTimeSolve = conTimeSol + "-O-" + i;
                //        }
                //        //contestContestant.UpSolve = upsolve + "--" + i;
                //        db.ContestContestants.Add(contestContestant);
                //    }
                //    catch (Exception)
                //    {

                //    }
                //}

                //conTimeSol = GetCellValue(spreadSheetDocument, rows[115].Descendants<Cell>().ElementAt(26));
                //upsolve = GetCellValue(spreadSheetDocument, rows[115].Descendants<Cell>().ElementAt(27));
                //contestContestant.ContestTimeSolve = conTimeSol;
                //contestContestant.UpSolve = upsolve;
                //db.ContestContestants.Add(contestContestant);

                for (int i = 12; i < contest.Count() + 12; i++)
                {
                    for (int col = 5, row = 0; col < (contestant.Count() * 2) + 5; row++)
                    {
                        ContestContestant contestContestant = new ContestContestant();
                        contestContestant.ContestantId = contestant[row].Id;
                        contestContestant.ContestId = contest[i - 12].Id;
                        string conTimeSol = "", upsolve = "";
                        try
                        {
                            conTimeSol = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(col));
                            //if(conTimeSol != "A")
                            //{
                            contestContestant.ContestTimeSolve = conTimeSol; // + "--" + i + "--" + c1; // Convert.ToInt32(conTimeSol);
                            //}
                            col++;
                        }
                        catch (Exception)
                        {
                            col++;
                            contestContestant.ContestTimeSolve = conTimeSol; // + "--" + i + "--" + c1;
                        }

                        try
                        {
                            upsolve = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(col));
                            //if (upsolve != "A")
                            //{
                            contestContestant.UpSolve = upsolve; // + "--" + i + "--" + c2; // Convert.ToInt32(upsolve);
                            //}  
                            col++;
                        }
                        catch (Exception)
                        {
                            col++;
                            contestContestant.UpSolve = upsolve; // + "--" + i + "--" + c2;
                        }

                        db.ContestContestants.Add(contestContestant);
                    }
                }

                //for (int col = 5, row = 5; row < contestant.Count() + 5; row++, col += 2)
                //{
                //    for (int i = 12; i < contest.Count() + 12; i++)
                //    {
                //        ContestContestant contestContestant = new ContestContestant();
                //        contestContestant.ContestantId = contestant[row - 5].Id;
                //        contestContestant.ContestId = contest[i - 12].Id;

                //        string conTimeSol = "", upsolve = "";
                //        try
                //        {
                //            conTimeSol = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(col));
                //            //if (conTimeSol != "A")
                //            //{
                //                contestContestant.ContestTimeSolve = conTimeSol; // Convert.ToInt32(conTimeSol);
                //            //}
                //        }
                //        catch (Exception)
                //        {
                //            contestContestant.ContestTimeSolve = conTimeSol;
                //        }

                //        try
                //        {
                //            upsolve = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(col+1));
                //            //if (upsolve != "A")
                //            //{
                //                contestContestant.UpSolve = upsolve; // Convert.ToInt32(upsolve);
                //            //}
                //        }
                //        catch (Exception)
                //        {
                //            contestContestant.UpSolve = upsolve;
                //        }

                //        db.ContestContestants.Add(contestContestant);
                //    }
                //}

                db.SaveChanges();
            }
            System.IO.File.Delete(path);

            return RedirectToAction("Index", "ContestContestants");
        }

        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
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
