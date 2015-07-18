using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinishLinePics.Models.Models.Mapping
{
    public class DistanceMap : EntityTypeConfiguration<Distance>
    {
        public DistanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RaceDistance)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Distances");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RaceDistance).HasColumnName("RaceDistance");
        }
    }
}
