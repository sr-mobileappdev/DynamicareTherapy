using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFClientDataService : EFBaseDataSerivce<DataModel.Models.Client, int>, DataService.IClients
    {
        public EFClientDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<Client, int>> GetKey()
        {
            return a => a.ClientID;
        }
    }
}
