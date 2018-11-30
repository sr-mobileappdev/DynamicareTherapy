using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   public class MonitorModel
    {
        public int IEPProgressMonitorID { get; set; }
        public int IEPProgressMonitorPeriodID { get; set; }
        public int ClientMPI { get; set; }
        public int TherapistID { get; set; }
        public string Therapist { get; set; }
        public int IEPProgressMonitorStatusID { get; set; }
        public Nullable<System.DateTime> DateEmailed { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
