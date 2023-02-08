using Estimate.Data.Installer;
using Estimate.ServiceGateway.Installer;
using Microsoft.Extensions.DependencyInjection;
using Estimate.ServiceGateway;
using Scrutor;
namespace Estimate.BusinessServices.Installer
{
    public class ServiceInstaller
    {
        private IServiceCollection _service;
        public ServiceInstaller(IServiceCollection service)
        {
            _service = service;
        }

        public void Install()
        {
            _service.AddSingleton<BaseGateway>();
            _service.Scan(scan => scan
                                    .FromAssemblyOf<ServiceInstaller>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithScopedLifetime());
            var dataInstaller = new DataInstaller(_service);
            dataInstaller.Install();
            var gatewayInstaller = new GatewayInstaller(_service);
            gatewayInstaller.Install();
        }
    }
}
