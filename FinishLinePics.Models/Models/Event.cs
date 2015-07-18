using System;
using System.Collections.Generic;

namespace FinishLinePics.Models.Models
{
    public partial class Event
    {
        public Event()
        {
            this.Photos = new List<Photo>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> RaceDate { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
