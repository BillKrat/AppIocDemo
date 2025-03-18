using AppIocDemo.Models.Entities;

namespace WeatherForecastDemo.Model.Interfaces
{
    public interface IWeatherFacade
    {
        List<WeatherForecast> GetWeatherList();
    }
}
