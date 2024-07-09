using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace Example.Services.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddExampleServices(this IServiceCollection services)
        {
            services.AddTransient<IExampleService, ExampleService>();
            return services;
        }
    }
}
