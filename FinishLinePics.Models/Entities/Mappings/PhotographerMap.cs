using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinishLinePics.Models.Entities.Mapping
{
    public class PhotographerMap : EntityTypeConfiguration<Photographer>
    {
        public PhotographerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Initials)
                .HasMaxLength(6);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Photographers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Initials).HasColumnName("Initials");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
        }
    }
}
