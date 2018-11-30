using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressMonitorOutcomeStatusMap : EntityTypeConfiguration<IEPProgressMonitorOutcomeStatus>
    {
        public IEPProgressMonitorOutcomeStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.IEPProgressMonitorOutcomeStatusID);

            // Properties
            this.Property(t => t.OutcomeStatus)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("IEPProgressMonitorOutcomeStatuses");
            this.Property(t => t.IEPProgressMonitorOutcomeStatusID).HasColumnName("IEPProgressMonitorOutcomeStatusID");
            this.Property(t => t.OutcomeStatus).HasColumnName("OutcomeStatus");
        }
    }
}
