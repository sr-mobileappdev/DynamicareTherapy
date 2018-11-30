using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class IEPProgressMonitorPeriod
    {
        public int IEPProgressMonitorPeriodID { get; set; }
        public string PeriodName { get; set; }
        public System.DateTime CutoffDate { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
