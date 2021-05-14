using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Donor
    {
        public Donor()
        {
            Donation = new HashSet<Donation>();
            Tree = new HashSet<Tree>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string FullName { get; set; }
        [StringLength(256)]
        public string FirstName { get; set; }
        [StringLength(256)]
        public string LastName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string Phone { get; set; }
        public int? OrganizationId { get; set; }

        [ForeignKey(nameof(OrganizationId))]
        [InverseProperty("Donor")]
        public virtual Organization Organization { get; set; }
        [InverseProperty("Donor")]
        public virtual ICollection<Donation> Donation { get; set; }
        [InverseProperty("Donor")]
        public virtual ICollection<Tree> Tree { get; set; }
    }
}
