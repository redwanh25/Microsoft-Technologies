using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIU_CPC_BlueDivision.Models
{
    public class Contest_Contestants_ContestContestant
    {
        public IEnumerable<ContestTable> contestTables { get; set; }
        public IEnumerable<ContestantsTable> contestantsTables { get; set; }
        public IEnumerable<ContestContestant> contestContestants { get; set; }
    }
}