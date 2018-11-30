using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataModel.Models;

namespace EFDataService
{
    public class EFOutcomeGoalsDataService : EFBaseDataSerivce<DataModel.Models.IEPOutcomeGoal, int>, DataService.IOutcomeGoals
    {
        public EFOutcomeGoalsDataService(CoCentrixDevContext Context) : base(Context)
        {
        }

        public override Expression<Func<IEPOutcomeGoal, int>> GetKey()
        {
            return a => a.IEPOutcomeGoalID;
        }
    }
}
