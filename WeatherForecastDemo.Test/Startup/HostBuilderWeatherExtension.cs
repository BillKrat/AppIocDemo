using AppIocDemo.Interfaces;
using AppIocDemo.LayerBusiness.Entities;
using AppIocDemo.LayerBusiness.Facades;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherForecastDemo.Test.Mocks;

namespace WeatherForecastDemo.Test.Startup
{
    public static class HostBuilderWeatherExtension
    {
        public static HostApplicationBuilder? ConfigureWeatherForecast(
            this HostApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddSingleton<WeatherFacade>();
            services.AddSingleton<IWeatherBe, WeatherBe>();
            services.AddSingleton<IWeatherDac, WeatherTestDac>();

            return builder;
        }

    }
}
