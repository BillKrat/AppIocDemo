using AppIocDemo.Models.Entities;

namespace WeatherForecastDemo.Model.Interfaces
{
    public interface IWeatherDac
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}
