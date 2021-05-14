using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Donation
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "numeric(15, 2)")]
        public decimal? Amount { get; set; }
        [StringLength(256)]
        public string DisplayName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DonationDate { get; set; }
        [StringLength(256)]
        public string Purpose { get; set; }
        public bool? Anonymous { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        public int? DonorId { get; set; }
        public int? FundId { get; set; }
        public int? TreeId { get; set; }
        public int? DonationStatusId { get; set; }
        public int? OrganizationId { get; set; }

        [ForeignKey(nameof(DonationStatusId))]
        [InverseProperty("Donation")]
        public virtual DonationStatus DonationStatus { get; set; }
        [ForeignKey(nameof(DonorId))]
        [InverseProperty("Donation")]
        public virtual Donor Donor { get; set; }
        [ForeignKey(nameof(FundId))]
        [InverseProperty("Donation")]
        public virtual Fund Fund { get; set; }
        [ForeignKey(nameof(OrganizationId))]
        [InverseProperty("Donation")]
        public virtual Organization Organization { get; set; }
        [ForeignKey(nameof(TreeId))]
        [InverseProperty("Donation")]
        public virtual Tree Tree { get; set; }
    }
}
