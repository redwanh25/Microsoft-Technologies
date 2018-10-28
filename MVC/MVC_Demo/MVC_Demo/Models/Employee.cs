using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    [Table("tblEmployee")]  // amder table er nam tblEmployee tai amader aita map kore dite hobe. na dile by default
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
    }
}