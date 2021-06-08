using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technical_Assessment.Models;

namespace Technical_Assessment.Controllers
{
    public class HomeController : Controller
    {
        TechnicalAssessmentDBEntities db = new TechnicalAssessmentDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetResult(JqueryDatatableParam param)
        {
            List<CustomColumnClass> listOfData1 = GenerateResult();
            List<CustomColumnClass> listOfData2 = new List<CustomColumnClass>();
            foreach (CustomColumnClass list in listOfData1)
            {
                CustomColumnClass ccc1 = new CustomColumnClass();
                ccc1.BlogPost = list.BlogPost;
                ccc1.Comment = "";
                ccc1.User = list.User;
                ccc1.Date = list.BlogPostDate.ToString("dd/MM/yyyy");
                ccc1.Result = list.Result;
                listOfData2.Add(ccc1);

                List<BlogPostComment> listOfBPC = db.BlogPostComments.Where(x => x.BlogPostId == list.BlogPostId).ToList();
                foreach(BlogPostComment bpc in listOfBPC)
                {
                    CustomColumnClass ccc2 = new CustomColumnClass();
                    ccc2.BlogPost = "";
                    ccc2.Comment = bpc.Text;
                    ccc2.User = bpc.User.UserName;
                    ccc2.Date = ((DateTime) bpc.Date).ToString("dd/MM/yyyy");
                    ccc2.Result = "Like (" + bpc.Like + ") Dislike (" + bpc.Dislike + ")";
                    listOfData2.Add(ccc2);
                }
            }
         
            //=========== Server Side Pagination ==============

            if (!string.IsNullOrEmpty(param.sSearch))
            {
                listOfData2 = listOfData2.Where(x => (x.BlogPost != null && x.BlogPost.Contains(param.sSearch.ToLower()))
                                              || (x.Comment != null && x.Comment.ToLower().Contains(param.sSearch.ToLower()))
                                              || (x.User != null && x.User.ToLower().Contains(param.sSearch.ToLower()))
                                              || (x.Date != null && x.Date.ToString().ToLower().Contains(param.sSearch.ToLower()))
                                              || (x.Result != null && x.Result.ToLower().Contains(param.sSearch.ToLower()))).ToList();
            }

            var displayResult = listOfData2.Skip(param.iDisplayStart).Take(param.iDisplayLength).ToList();
            var totalRecords = listOfData2.Count();

            return Json(new
            {
                param.sEcho,
                iTotalRecords = totalRecords,
                iTotalDisplayRecords = totalRecords,
                aaData = displayResult
            }, JsonRequestBehavior.AllowGet);
        }

        public List<CustomColumnClass> GenerateResult()
        {
            List<CustomColumnClass> listOfDate = db.BlogPostComments.GroupBy(x => x.BlogPostId)
                .Select(item => new CustomColumnClass
                {
                    BlogPostId = item.FirstOrDefault().BlogPost.Id,
                    BlogPost = item.FirstOrDefault().BlogPost.Title,
                    User = item.FirstOrDefault().BlogPost.User.UserName,
                    BlogPostDate = (DateTime)item.FirstOrDefault().BlogPost.Date,
                    CommentCount = item.Count(),
                    Result = item.Count() + " Comments"
                }).ToList();

            return listOfDate;
        }
    }
}