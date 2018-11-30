using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class IEPOutcomeGoalMap : EntityTypeConfiguration<IEPOutcomeGoal>
    {
        public IEPOutcomeGoalMap()
        {
            // Primary Key
            this.HasKey(t => t.IEPOutcomeGoalID);

            // Properties
            this.Property(t => t.GoalStatement)
                .HasMaxLength(4000);

            this.Property(t => t.CurrentStatus)
                .HasMaxLength(8000);

            this.Property(t => t.Strategies)
                .HasMaxLength(8000);

            this.Property(t => t.ProgressMeasurements)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("IEPOutcomeGoals");
            this.Property(t => t.IEPOutcomeGoalID).HasColumnName("IEPOutcomeGoalID");
            this.Property(t => t.ClientMPI).HasColumnName("ClientMPI");
            this.Property(t => t.GoalNumber).HasColumnName("GoalNumber");
            this.Property(t => t.DateGoalDeveloped).HasColumnName("DateGoalDeveloped");
            this.Property(t => t.DateGoalCompleted).HasColumnName("DateGoalCompleted");
            this.Property(t => t.GoalStatement).HasColumnName("GoalStatement");
            this.Property(t => t.CurrentStatus).HasColumnName("CurrentStatus");
            this.Property(t => t.Strategies).HasColumnName("Strategies");
            this.Property(t => t.ProgressMeasurements).HasColumnName("ProgressMeasurements");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
