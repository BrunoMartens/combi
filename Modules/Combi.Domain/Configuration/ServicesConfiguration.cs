using Combi.Domain.Services;
using Combi.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Combi.Domain.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddCombiDomain(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperDomainProfile));
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IDemoService, DemoService>();
        }
    }
}
