using AppIocDemo.LayerBusiness.Facades;
using AppIocDemo.LayerData.AccessComponents;

namespace AppIocDemo.LayerBusiness.Components
{
    public static class WebApplicationBuilderWeatherExtension
    {
        public static WebApplicationBuilder? ConfigureWeather(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<WeatherFacade>();
            builder.Services.AddSingleton<WeatherDac>();
            builder.Services.AddSingleton<ILogger, DebugLogger>();
            return builder;
        }

    }
}
