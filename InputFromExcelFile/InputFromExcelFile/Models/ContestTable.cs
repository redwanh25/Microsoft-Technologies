//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InputFromExcelFile.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContestTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContestTable()
        {
            this.ContestContestants = new HashSet<ContestContestant>();
        }
    
        public int Id { get; set; }
        public string ContestName { get; set; }
        public string ContestLink { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> NumberOfProblems { get; set; }
        public Nullable<int> Participation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContestContestant> ContestContestants { get; set; }
    }
}
