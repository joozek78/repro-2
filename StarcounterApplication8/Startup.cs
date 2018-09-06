using Microsoft.Extensions.DependencyInjection;
using Starcounter.Advanced;
using Starcounter.Startup.Abstractions;
using Starcounter.Startup.Routing;

namespace StarcounterApplication8
{
    internal class Startup : IStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouter(false);
        }

        public void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.ApplicationServices.GetRouter().RegisterAllFromCurrentAssembly();
            Blender.MapUri("/StarcounterApplication8/Main","main", new[]{string.Empty});
        }
    }
}