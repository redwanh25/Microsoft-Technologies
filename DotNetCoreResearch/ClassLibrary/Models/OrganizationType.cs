using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class OrganizationType
    {
        public OrganizationType()
        {
            Organization = new HashSet<Organization>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }

        [InverseProperty("OrganizationType")]
        public virtual ICollection<Organization> Organization { get; set; }
    }
}
