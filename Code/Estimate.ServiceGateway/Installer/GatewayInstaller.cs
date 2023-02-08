using Microsoft.Extensions.DependencyInjection;

namespace Estimate.ServiceGateway.Installer
{
    public class GatewayInstaller
    {
        private IServiceCollection _service;
        public GatewayInstaller(IServiceCollection service)
        {
            _service = service;
        }

        public void Install()
        {
            _service.AddAutoMapper(typeof(BaseGateway));
             _service.Scan(scan => scan
                                    .FromAssemblyOf<GatewayInstaller>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithScopedLifetime());
        }
    }
}
