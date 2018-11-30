using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFMonitorDataService : EFBaseDataSerivce<DataModel.Models.IEPProgressMonitor, int>, DataService.IMonitor
    {
        public EFMonitorDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<IEPProgressMonitor, int>> GetKey()
        {
            return a => a.IEPProgressMonitorID;
        }
    }
}
