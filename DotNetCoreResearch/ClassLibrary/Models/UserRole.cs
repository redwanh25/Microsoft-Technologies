using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class UserRole
    {
        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
