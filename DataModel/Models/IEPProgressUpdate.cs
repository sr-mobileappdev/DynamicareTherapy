using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class IEPProgressUpdate
    {
        public int IEPProgressUpdateID { get; set; }
        public int IEPOutcomeGoalID { get; set; }
        public int IEPProgressMonitorOutcomeStatusID { get; set; }
        public System.DateTime DateOfReview { get; set; }
        public string OutcomeStatusText { get; set; }
        public string ProgressInformation { get; set; }
        public string NewOutcomeGoal { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
