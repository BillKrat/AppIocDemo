using AppIocDemo.Interfaces;
using AppIocDemo.LayerBusiness.Entities;
using AppIocDemo.LayerBusiness.Facades;
using AppIocDemo.LayerData.AccessComponents;

namespace AppIocDemo.LayerBusiness.Components
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
