//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIU_CPC_BlueDivision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ContestTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContestTable()
        {
            this.ContestContestants = new HashSet<ContestContestant>();
        }
    
        public int Id { get; set; }
        [Required]
        public string ContestName { get; set; }
        //[Required]
        public string ContestLink { get; set; }
        [DataType(DataType.Date)] //[Required]
        public Nullable<System.DateTime> Date { get; set; }
        [Required]
        public Nullable<int> NumberOfProblems { get; set; }
        [Required]
        public Nullable<int> Participation { get; set; }
        [Required]
        public Nullable<int> ContestTrackerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContestContestant> ContestContestants { get; set; }
        public virtual ContestTracker ContestTracker { get; set; }
    }
}
