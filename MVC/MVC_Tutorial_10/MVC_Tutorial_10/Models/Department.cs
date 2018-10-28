using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MVC_Tutorial_10.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHeadName { get; set; }
       // public List<Person> Persons { get; set; }
    }
}