// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinishLinePics.Models.Entities
{
    public class ExampleEntity : BaseGuidEntity
    {
        // Id is a Guid and inherited from BaseEntity
        public string Name { get; set; }
    }
}
