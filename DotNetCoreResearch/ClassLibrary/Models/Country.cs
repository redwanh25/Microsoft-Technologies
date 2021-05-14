using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Country
    {
        public Country()
        {
            Organization = new HashSet<Organization>();
            XcadetUser = new HashSet<XcadetUser>();
        }

        [Key]
        [StringLength(2)]
        public string Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }

        [InverseProperty("Country")]
        public virtual ICollection<Organization> Organization { get; set; }
        [InverseProperty("Country")]
        public virtual ICollection<XcadetUser> XcadetUser { get; set; }
    }
}
