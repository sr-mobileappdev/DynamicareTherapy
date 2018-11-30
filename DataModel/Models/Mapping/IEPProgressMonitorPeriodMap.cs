using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressMonitorPeriodMap : EntityTypeConfiguration<IEPProgressMonitorPeriod>
    {
        public IEPProgressMonitorPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IEPProgressMonitorPeriodID, t.PeriodName, t.CutoffDate });

            // Properties
            this.Property(t => t.IEPProgressMonitorPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("IEPProgressMonitorPeriods");
            this.Property(t => t.IEPProgressMonitorPeriodID).HasColumnName("IEPProgressMonitorPeriodID");
            this.Property(t => t.PeriodName).HasColumnName("PeriodName");
            this.Property(t => t.CutoffDate).HasColumnName("CutoffDate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
