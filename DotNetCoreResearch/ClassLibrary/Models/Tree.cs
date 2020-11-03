using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class Tree
    {
        public Tree()
        {
            Donation = new HashSet<Donation>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DatePlanted { get; set; }
        [StringLength(256)]
        public string PlacePlated { get; set; }
        [Column(TypeName = "numeric(15, 2)")]
        public decimal? CostToPlant { get; set; }
        [Column("ReferenceID")]
        [StringLength(256)]
        public string ReferenceId { get; set; }
        [StringLength(256)]
        public string FruitName { get; set; }
        public int? DonorId { get; set; }
        public int? OrganizationId { get; set; }

        [ForeignKey(nameof(DonorId))]
        [InverseProperty("Tree")]
        public virtual Donor Donor { get; set; }
        [ForeignKey(nameof(OrganizationId))]
        [InverseProperty("Tree")]
        public virtual Organization Organization { get; set; }
        [InverseProperty("Tree")]
        public virtual ICollection<Donation> Donation { get; set; }
    }
}
