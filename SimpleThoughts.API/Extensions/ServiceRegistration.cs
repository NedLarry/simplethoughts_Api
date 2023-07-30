using Abstractions.Interfaces;
using MediatR;
using Services;

namespace SimpleThoughts.API.Extensions
{
    public static class ServiceRegistration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IPingService, PingService>();
        }
    }
}
