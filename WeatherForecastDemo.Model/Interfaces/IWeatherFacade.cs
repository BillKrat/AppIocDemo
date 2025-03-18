using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface IWeatherFacade
    {
        List<WeatherForecast> GetWeatherList();
    }
}
