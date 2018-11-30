using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class TherapistMap : EntityTypeConfiguration<Therapist>
    {
        public TherapistMap()
        {
            // Primary Key
            this.HasKey(t => t.TherapistID);

            // Properties
            this.Property(t => t.TherapistID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TherapistName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Therapists");
            this.Property(t => t.TherapistID).HasColumnName("TherapistID");
            this.Property(t => t.TherapistName).HasColumnName("TherapistName");
        }
    }
}
