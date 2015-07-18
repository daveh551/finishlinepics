using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinishLinePics.Models.Entities.Mapping
{
    public class PhotoMap : EntityTypeConfiguration<Photo>
    {
        public PhotoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Station)
                .HasMaxLength(50);

            this.Property(t => t.Card)
                .HasMaxLength(10);

            this.Property(t => t.Path)
                .HasMaxLength(512);

            this.Property(t => t.FStop)
                .HasMaxLength(10);

            this.Property(t => t.ShutterSpeed)
                .HasMaxLength(10);

            this.Property(t => t.Server)
                .HasMaxLength(100);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Photos");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.Station).HasColumnName("Station");
            this.Property(t => t.Card).HasColumnName("Card");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.Hres).HasColumnName("Hres");
            this.Property(t => t.Vres).HasColumnName("Vres");
            this.Property(t => t.FStop).HasColumnName("FStop");
            this.Property(t => t.ShutterSpeed).HasColumnName("ShutterSpeed");
            this.Property(t => t.ISOspeed).HasColumnName("ISOspeed");
            this.Property(t => t.FocalLength).HasColumnName("FocalLength");
            this.Property(t => t.BasedOn).HasColumnName("BasedOn");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.LastAccessed).HasColumnName("LastAccessed");
            this.Property(t => t.Server).HasColumnName("Server");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Photographer_Id).HasColumnName("Photographer_Id");

            // Relationships
            this.HasRequired(t => t.Event)
                .WithMany(t => t.Photos)
                .HasForeignKey(d => d.EventId);
            this.HasOptional(t => t.Photographer)
                .WithMany(t => t.Photos)
                .HasForeignKey(d => d.Photographer_Id);

        }
    }
}
