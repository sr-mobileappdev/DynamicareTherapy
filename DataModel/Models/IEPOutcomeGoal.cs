using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class IEPOutcomeGoal
    {
        public int IEPOutcomeGoalID { get; set; }
        public int ClientMPI { get; set; }
        public int GoalNumber { get; set; }
        public System.DateTime DateGoalDeveloped { get; set; }
        public Nullable<System.DateTime> DateGoalCompleted { get; set; }
        public string GoalStatement { get; set; }
        public string CurrentStatus { get; set; }
        public string Strategies { get; set; }
        public string ProgressMeasurements { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    }
}
