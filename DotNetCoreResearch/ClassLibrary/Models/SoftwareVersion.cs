using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class SoftwareVersion
    {
        public SoftwareVersion()
        {
            Organization = new HashSet<Organization>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string Version { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BuildDate { get; set; }
        [StringLength(256)]
        public string VersionType { get; set; }

        [InverseProperty("SoftwareVersion")]
        public virtual ICollection<Organization> Organization { get; set; }
    }
}
