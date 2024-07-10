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
            services.AddTransient<IThoughtService, ThoughtService>();
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ThoughtContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        }
    }
}
