using FubuMVC.Spark;
using FubuMVC.Core;
using SystemMonitoring.Features;

namespace SystemMonitoring.Configuration
{
    public class SystemMonitoringRegistry : FubuRegistry
    {
        public SystemMonitoringRegistry()
        {
            IncludeDiagnostics(true);

            Applies.
                ToThisAssembly();

            this.UseSpark();

            ApplyHandlerConventions(typeof(FeaturesMarker));

            Views.TryToAttachWithDefaultConventions();

            Routes.HomeIs<GetHandler>(x => x.Execute(new DashboardRequestModel()));
        }
    }
}