using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Tutorial_10.Models
{
    [Table("tblPerson")]
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int DepartmentID { get; set; }
    }
}