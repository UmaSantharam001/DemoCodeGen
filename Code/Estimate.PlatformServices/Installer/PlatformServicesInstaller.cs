using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using ElmahCore.Mvc;
using ElmahCore;
using Estimate.PlatformServices.Filters;
using Estimate.BusinessServices.Installer;

namespace Estimate.PlatformServices.Installer
{
    public class PlatformServicesInstaller
    {
        private IServiceCollection _service;
        public IConfiguration _configuration { get; }
        
        public PlatformServicesInstaller(IServiceCollection service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        public void Install()
        {   
            _service.AddControllers(options => 
                options.Filters.Add<HttpResponseExceptionFilter>());

            string version = _configuration.GetValue("BuildVersion", "0.0.0.0");
            string branch = _configuration.GetValue("BuildBransh", "local");
            // Register the Swagger generator, defining 1 or more Swagger documents
            _service.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Estimate PlatformServices", Version = version + "-" + branch});
            });

            _service.AddElmah<XmlFileErrorLog>(options=>
            {
                options.LogPath = "./log";
            });

            var serviceInstaller = new ServiceInstaller(_service);
            serviceInstaller.Install();
        }
    }
}