using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinishLinePics.Models.Entities.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.EventName)
                .HasMaxLength(150);

            this.Property(t => t.Location)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Events");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.RaceDate).HasColumnName("RaceDate");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
