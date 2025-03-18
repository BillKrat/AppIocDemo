using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherForecastDemo.Model.Interfaces;
using WeatherForecastDemo.Test.Mocks;
using WeatherForeCastDemo.BusinessLayer.Components;
using WeatherForeCastDemo.BusinessLayer.Facades;

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
