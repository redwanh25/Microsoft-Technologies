using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalReportsProject.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}