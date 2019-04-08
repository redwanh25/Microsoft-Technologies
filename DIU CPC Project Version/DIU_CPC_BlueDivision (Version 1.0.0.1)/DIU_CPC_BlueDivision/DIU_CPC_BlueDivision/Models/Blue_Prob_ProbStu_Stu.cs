using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.Models
{
    public class Blue_Prob_ProbStu_Stu
    {
        public IEnumerable<BlueSheet> blueSheets { get; set; }
        public IEnumerable<Problem> problems { get; set; }
        public IEnumerable<ProblemsStudent> problemsStudents { get; set; }
        public IEnumerable<Student> students { get; set; }
    }
}