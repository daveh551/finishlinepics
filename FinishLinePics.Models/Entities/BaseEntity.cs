// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinishLinePics.Models.Entities
{
    public abstract class BaseGuidEntity : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
    }

    public abstract class BaseIntEntity : IIdentifiable<int>
    {
        public int Id { get; set; }
    }

    public abstract class BaseStringEntity : IIdentifiable<string>
    {
        public string Id { get; set; }
    }
}
