using WeatherForecastDemo.DataLayer.AccessComponents;
using WeatherForecastDemo.Model.Interfaces;
using WeatherForeCastDemo.BusinessLayer.Components;
using WeatherForeCastDemo.BusinessLayer.Facades;

namespace AppIocDemo.Startup
{
    public static class WebAppBuilderWeatherExtension
    {
        public static WebApplicationBuilder? ConfigureWeather(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<WeatherFacade>();
            builder.Services.AddSingleton<IWeatherBe, WeatherBe>();
            builder.Services.AddSingleton<IWeatherDac, WeatherDac>();
            return builder;
        }

    }
}
