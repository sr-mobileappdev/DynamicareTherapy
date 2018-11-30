using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataModel.Models.Mapping;

namespace DataModel.Models
{
    public partial class CoCentrixDevContext : DbContext
    {
        static CoCentrixDevContext()
        {
            Database.SetInitializer<CoCentrixDevContext>(null);
        }

        public CoCentrixDevContext()
            : base("Name=CoCentrixDevContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<IEPOutcomeGoal> IEPOutcomeGoals { get; set; }
        public DbSet<IEPProgressMonitorDetail> IEPProgressMonitorDetails { get; set; }
        public DbSet<IEPProgressMonitorOutcomeStatus> IEPProgressMonitorOutcomeStatuses { get; set; }
        public DbSet<IEPProgressMonitorPeriod> IEPProgressMonitorPeriods { get; set; }
        public DbSet<IEPProgressMonitor> IEPProgressMonitors { get; set; }
        public DbSet<IEPProgressMonitorStatus> IEPProgressMonitorStatuses { get; set; }
        public DbSet<IEPProgressUpdate> IEPProgressUpdates { get; set; }
        public DbSet<Therapist> Therapists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new IEPOutcomeGoalMap());
            modelBuilder.Configurations.Add(new IEPProgressMonitorDetailMap());
            modelBuilder.Configurations.Add(new IEPProgressMonitorOutcomeStatusMap());
            modelBuilder.Configurations.Add(new IEPProgressMonitorPeriodMap());
            modelBuilder.Configurations.Add(new IEPProgressMonitorMap());
            modelBuilder.Configurations.Add(new IEPProgressMonitorStatusMap());
            modelBuilder.Configurations.Add(new IEPProgressUpdateMap());
            modelBuilder.Configurations.Add(new TherapistMap());
        }
    }
}
