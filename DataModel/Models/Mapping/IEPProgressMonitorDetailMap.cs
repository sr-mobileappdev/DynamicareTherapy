using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressMonitorDetailMap : EntityTypeConfiguration<IEPProgressMonitorDetail>
    {
        public IEPProgressMonitorDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.IEPProgressMonitorDetailID);

            // Properties
            this.Property(t => t.ProgressInformation)
                .IsRequired()
                .HasMaxLength(8000);

            this.Property(t => t.NewOutcomeGoal)
                .IsRequired()
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("IEPProgressMonitorDetails");
            this.Property(t => t.IEPProgressMonitorDetailID).HasColumnName("IEPProgressMonitorDetailID");
            this.Property(t => t.IEPlProgressMonitorID).HasColumnName("IEPlProgressMonitorID");
            this.Property(t => t.IEPOutcomeGoalID).HasColumnName("IEPOutcomeGoalID");
            this.Property(t => t.IEPProgressMonitorOutcomeStatusID).HasColumnName("IEPProgressMonitorOutcomeStatusID");
            this.Property(t => t.ProgressInformation).HasColumnName("ProgressInformation");
            this.Property(t => t.NewOutcomeGoal).HasColumnName("NewOutcomeGoal");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
