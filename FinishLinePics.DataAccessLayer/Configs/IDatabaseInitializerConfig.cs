// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Castle.Components.DictionaryAdapter;

namespace FinishLinePics.DataAccessLayer.Configs
{
    [KeyPrefix("EntityFramework.")]
    public interface IDatabaseInitializerConfig
    {
        InitializerTypes Initializer { get; set; }
    }
}