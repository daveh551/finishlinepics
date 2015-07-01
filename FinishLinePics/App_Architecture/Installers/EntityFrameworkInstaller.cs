// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Data.Entity;
using FinishLinePics.DataAccessLayer.Configs;
using FinishLinePics.DataAccessLayer;
using FinishLinePics.App_Architecture.Services.Data;
using Highway.Data;
using FinishLinePics.Models.Entities;

namespace FinishLinePics.App_Architecture.Installers
{
    public class EntityFrameworkInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var config = container.Resolve<IDatabaseInitializerConfig>();
            switch (config.Initializer)
            {
                case InitializerTypes.DropCreateDatabaseAlways:
                    container.Register(Component.For<IDatabaseInitializer<DomainContext<Domain>>>()
                        .ImplementedBy<DropCreateDatabaseAlways<DomainContext<Domain>>>().LifestyleSingleton());
                    break;
                case InitializerTypes.DropCreateDatabaseIfModelChanges:
                    container.Register(Component.For<IDatabaseInitializer<DomainContext<Domain>>>()
                        .ImplementedBy<DropCreateDatabaseIfModelChanges<DomainContext<Domain>>>().LifestyleSingleton());
                    break;
                case InitializerTypes.CreateDatabaseIfNotExists:
                    container.Register(Component.For<IDatabaseInitializer<DomainContext<Domain>>>()
                        .ImplementedBy<CreateDatabaseIfNotExists<DomainContext<Domain>>>().LifestyleSingleton());
                    break;
                case InitializerTypes.NullDatabaseInitializer:
                    container.Register(Component.For<IDatabaseInitializer<DomainContext<Domain>>>()
                        .ImplementedBy<NullDatabaseInitializer<DomainContext<Domain>>>().LifestyleSingleton());
                    break;
                default:
                    throw new NotImplementedException("Unknown Enumeration Value");
            }
        }
    }
}
