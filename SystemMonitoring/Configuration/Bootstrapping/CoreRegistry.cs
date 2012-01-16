using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;

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
                    });
        }
    }
}