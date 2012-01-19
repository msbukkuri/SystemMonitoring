using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;
using SystemMonitoring.Repositories;

namespace SystemMonitoring.Configuration.Bootstrapping
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            Scan(x =>
                    {
                        x.TheCallingAssembly();
                        x.LookForRegistries();
                        x.WithDefaultConventions();

                        For<IRepository>().
                            Use<ClientRepository>();
                    });
        }
    }
}