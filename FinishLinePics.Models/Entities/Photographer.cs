using System;
using System.Collections.Generic;

namespace FinishLinePics.Models.Entities
{
    public partial class Photographer : BaseIntEntity
    {
        public Photographer()
        {
            this.Photos = new List<Photo>();
        }

        public string Name { get; set; }
        public string Initials { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
