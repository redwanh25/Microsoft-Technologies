using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technical_Assessment.Models
{
    public class CustomColumnClass
    {
        public int BlogPostId { get; set; }
        public string BlogPost { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public DateTime BlogPostDate { get; set; }
        public DateTime CommentDate { get; set; }
        public DateTime Date { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int CommentCount { get; set; }
        public string Result { get; set; }
    }
}