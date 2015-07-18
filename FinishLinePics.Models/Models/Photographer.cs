using System;
using System.Collections.Generic;

namespace FinishLinePics.Models.Models
{
    public partial class Photographer
    {
        public Photographer()
        {
            this.Photos = new List<Photo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
