using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPProgressUpdateMap : EntityTypeConfiguration<IEPProgressUpdate>
    {
        public IEPProgressUpdateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IEPProgressUpdateID, t.IEPOutcomeGoalID, t.IEPProgressMonitorOutcomeStatusID, t.DateOfReview, t.ProgressInformation });

            // Properties
            this.Property(t => t.IEPProgressUpdateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IEPOutcomeGoalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IEPProgressMonitorOutcomeStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OutcomeStatusText)
                .HasMaxLength(300);

            this.Property(t => t.ProgressInformation)
                .IsRequired()
                .HasMaxLength(8000);

            this.Property(t => t.NewOutcomeGoal)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("IEPProgressUpdates");
            this.Property(t => t.IEPProgressUpdateID).HasColumnName("IEPProgressUpdateID");
            this.Property(t => t.IEPOutcomeGoalID).HasColumnName("IEPOutcomeGoalID");
            this.Property(t => t.IEPProgressMonitorOutcomeStatusID).HasColumnName("IEPProgressMonitorOutcomeStatusID");
            this.Property(t => t.DateOfReview).HasColumnName("DateOfReview");
            this.Property(t => t.OutcomeStatusText).HasColumnName("OutcomeStatusText");
            this.Property(t => t.ProgressInformation).HasColumnName("ProgressInformation");
            this.Property(t => t.NewOutcomeGoal).HasColumnName("NewOutcomeGoal");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
