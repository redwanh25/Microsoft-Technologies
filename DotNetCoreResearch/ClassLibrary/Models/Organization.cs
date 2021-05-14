using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Donation = new HashSet<Donation>();
            Donor = new HashSet<Donor>();
            Fund = new HashSet<Fund>();
            Tree = new HashSet<Tree>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string Phone { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public byte[] Image { get; set; }
        [StringLength(256)]
        public string Address { get; set; }
        [StringLength(256)]
        public string City { get; set; }
        [StringLength(256)]
        public string State { get; set; }
        [StringLength(256)]
        public string Zip { get; set; }
        [StringLength(2)]
        public string CountryId { get; set; }
        [StringLength(256)]
        public string LegalName { get; set; }
        [StringLength(128)]
        public string ContactPersonId { get; set; }
        [StringLength(1000)]
        public string Token { get; set; }
        [StringLength(256)]
        public string SoftwareName { get; set; }
        [Column("EIN")]
        [StringLength(256)]
        public string Ein { get; set; }
        [StringLength(256)]
        public string ExemptStatus { get; set; }
        [StringLength(3000)]
        public string Mission { get; set; }
        [StringLength(3000)]
        public string SignificantActivities { get; set; }
        public int? NumberOfVotingMembers { get; set; }
        public int? NumberOfVolunteers { get; set; }
        public int? NumberOfPersonEmployed { get; set; }
        public int? FormOfOrganization { get; set; }
        public int? SoftwareVersionId { get; set; }
        public int? OrganizationTypeId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Organization")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(OrganizationTypeId))]
        [InverseProperty("Organization")]
        public virtual OrganizationType OrganizationType { get; set; }
        [ForeignKey(nameof(SoftwareVersionId))]
        [InverseProperty("Organization")]
        public virtual SoftwareVersion SoftwareVersion { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Donation> Donation { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Donor> Donor { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Fund> Fund { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Tree> Tree { get; set; }
    }
}
