using System;
using System.Collections.Generic;

namespace FinishLinePics.Models.Entities
{
    public partial class Event : BaseIntEntity
    {
        public Event()
        {
            this.Photos = new List<Photo>();
        }

        public string EventName { get; set; }
        public Nullable<System.DateTime> RaceDate { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
