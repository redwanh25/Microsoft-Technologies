using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    [Table("XCadetUser")]
    public partial class XcadetUser
    {
        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string FirstName { get; set; }
        [StringLength(256)]
        public string LastName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string PhoneNumber { get; set; }
        public int? BatchId { get; set; }
        [StringLength(256)]
        public string CadetNo { get; set; }
        [StringLength(256)]
        public string Address { get; set; }
        [StringLength(256)]
        public string City { get; set; }
        [StringLength(256)]
        public string State { get; set; }
        [StringLength(2)]
        public string CountryId { get; set; }
        public int? ProfessionId { get; set; }
        [StringLength(256)]
        public string Major { get; set; }
        [StringLength(256)]
        public string Specialty { get; set; }
        [Column("LTM")]
        public bool? Ltm { get; set; }
        public bool? SubscriptionPaid { get; set; }
        [StringLength(1000)]
        public string ShortBiography { get; set; }

        [ForeignKey(nameof(BatchId))]
        [InverseProperty("XcadetUser")]
        public virtual Batch Batch { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("XcadetUser")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(ProfessionId))]
        [InverseProperty("XcadetUser")]
        public virtual Profession Profession { get; set; }
    }
}
