using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ClientID, t.ClientMPI });

            // Properties
            this.Property(t => t.ClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClientMPI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MCI)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Clients");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ClientMPI).HasColumnName("ClientMPI");
            this.Property(t => t.MCI).HasColumnName("MCI");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
        }
    }
}
