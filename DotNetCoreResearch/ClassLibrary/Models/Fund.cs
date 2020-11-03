using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Fund
    {
        public Fund()
        {
            Donation = new HashSet<Donation>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public int? OrganizationId { get; set; }

        [ForeignKey(nameof(OrganizationId))]
        [InverseProperty("Fund")]
        public virtual Organization Organization { get; set; }
        [InverseProperty("Fund")]
        public virtual ICollection<Donation> Donation { get; set; }
    }
}
