using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface IWeatherDac
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}
