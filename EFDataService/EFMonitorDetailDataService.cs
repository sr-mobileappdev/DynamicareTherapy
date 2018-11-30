using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFMonitorDetailDataService : EFBaseDataSerivce<DataModel.Models.IEPProgressMonitorDetail, int>, DataService.IMonitorDetail
    {
        public EFMonitorDetailDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<IEPProgressMonitorDetail, int>> GetKey()
        {
            return a => a.IEPProgressMonitorDetailID;
        }
    }
}
