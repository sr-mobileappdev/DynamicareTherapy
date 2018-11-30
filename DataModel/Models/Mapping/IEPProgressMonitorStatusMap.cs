using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressMonitorStatusMap : EntityTypeConfiguration<IEPProgressMonitorStatus>
    {
        public IEPProgressMonitorStatusMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IEPProgressMonitorStatusID, t.Status });

            // Properties
            this.Property(t => t.IEPProgressMonitorStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IEPProgressMonitorStatuses");
            this.Property(t => t.IEPProgressMonitorStatusID).HasColumnName("IEPProgressMonitorStatusID");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
