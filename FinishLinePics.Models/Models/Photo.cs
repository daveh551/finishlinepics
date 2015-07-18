using System;
using System.Collections.Generic;

namespace FinishLinePics.Models.Models
{
    public partial class Photo
    {
        public System.Guid Id { get; set; }
        public int EventId { get; set; }
        public string Station { get; set; }
        public string Card { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Path { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<int> Hres { get; set; }
        public Nullable<int> Vres { get; set; }
        public string FStop { get; set; }
        public string ShutterSpeed { get; set; }
        public Nullable<short> ISOspeed { get; set; }
        public Nullable<short> FocalLength { get; set; }
        public Nullable<System.Guid> BasedOn { get; set; }
        public long FileSize { get; set; }
        public Nullable<System.DateTime> LastAccessed { get; set; }
        public string Server { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Photographer_Id { get; set; }
        public virtual Event Event { get; set; }
        public virtual Photographer Photographer { get; set; }
    }
}
