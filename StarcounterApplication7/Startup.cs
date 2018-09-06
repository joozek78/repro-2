using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Starcounter;
using Starcounter.Advanced;
using Starcounter.Startup.Abstractions;
using Starcounter.Startup.Routing;

namespace StarcounterApplication7
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
            Blender.MapUri("/StarcounterApplication7/Main", "main", new[] { string.Empty });
            Handle.GET("/StarcounterApplication7/Legacy", () => Db.Scope(() => new ViewModelWrapper()
            {
                InnerJson = Self.GET("/StarcounterApplication7/Main")
            }));
        }
    }
}