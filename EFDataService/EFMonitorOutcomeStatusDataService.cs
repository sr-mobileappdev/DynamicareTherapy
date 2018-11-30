using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFMonitorOutcomeStatusDataService : EFBaseDataSerivce<DataModel.Models.IEPProgressMonitorOutcomeStatus, int>, DataService.IMonitorOutcomeStatus
    {
        public EFMonitorOutcomeStatusDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<IEPProgressMonitorOutcomeStatus, int>> GetKey()
        {
            return a => a.IEPProgressMonitorOutcomeStatusID;
        }
    }
}
