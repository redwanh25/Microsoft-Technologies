using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Profession
    {
        public Profession()
        {
            XcadetUser = new HashSet<XcadetUser>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }

        [InverseProperty("Profession")]
        public virtual ICollection<XcadetUser> XcadetUser { get; set; }
    }
}
