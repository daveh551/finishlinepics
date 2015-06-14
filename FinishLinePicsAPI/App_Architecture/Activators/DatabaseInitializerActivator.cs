// [[Highway.Onramp.MVC.Data]]
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using FinishLinePicsAPI.App_Architecture.Activators;
using FinishLinePicsAPI.App_Architecture.Services.Data;
using Highway.Data;
using FinishLinePicsAPI.Entities;

[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof(DatabaseInitializerActivator), 
    "PostStartup")]
namespace FinishLinePicsAPI.App_Architecture.Activators
{
    public static class DatabaseInitializerActivator
    {
        public static void PostStartup()
        {
#pragma warning disable 618
            var initializer = IoC.Container.Resolve<IDatabaseInitializer<DomainContext<Domain>>>();
#pragma warning restore 618
            Database.SetInitializer(initializer);
        }
    }
}