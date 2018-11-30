using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class IEPProgressMonitorDetail
    {
        public int IEPProgressMonitorDetailID { get; set; }
        public int IEPlProgressMonitorID { get; set; }
        public int IEPOutcomeGoalID { get; set; }
        public int IEPProgressMonitorOutcomeStatusID { get; set; }
        public string ProgressInformation { get; set; }
        public string NewOutcomeGoal { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
