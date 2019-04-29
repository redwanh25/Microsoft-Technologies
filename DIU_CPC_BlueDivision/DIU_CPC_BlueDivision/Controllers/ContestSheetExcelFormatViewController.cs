using DIU_CPC_BlueDivision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ContestSheetExcelFormatViewController : Controller
    {
        // GET: ContestSheetExcelFormatView
        public ActionResult Index()
        {
            ContestAndContestantsEntities db = new ContestAndContestantsEntities();
            Contest_Contestants_ContestContestant ccc = new Contest_Contestants_ContestContestant();
            ccc.contestTables = db.ContestTables.ToList();
            ccc.contestantsTables = db.ContestantsTables.ToList();
            ccc.contestContestants = db.ContestContestants.ToList();
            return View(ccc);
        }
    }
}