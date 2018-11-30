using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressMonitorMap : EntityTypeConfiguration<IEPProgressMonitor>
    {
        public IEPProgressMonitorMap()
        {
            // Primary Key
            this.HasKey(t => t.IEPProgressMonitorID);

            // Properties
            // Table & Column Mappings
            this.ToTable("IEPProgressMonitors");
            this.Property(t => t.IEPProgressMonitorID).HasColumnName("IEPProgressMonitorID");
            this.Property(t => t.IEPProgressMonitorPeriodID).HasColumnName("IEPProgressMonitorPeriodID");
            this.Property(t => t.ClientMPI).HasColumnName("ClientMPI");
            this.Property(t => t.TherapistID).HasColumnName("TherapistID");
            this.Property(t => t.IEPProgressMonitorStatusID).HasColumnName("IEPProgressMonitorStatusID");
            this.Property(t => t.DateEmailed).HasColumnName("DateEmailed");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
