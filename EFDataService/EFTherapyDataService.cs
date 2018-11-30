using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFTherapyDataService : EFBaseDataSerivce<DataModel.Models.Therapist, int>, DataService.ITherapy
    {
        public EFTherapyDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<Therapist, int>> GetKey()
        {
            return a => a.TherapistID;
        }
    }
}
