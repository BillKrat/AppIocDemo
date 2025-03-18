using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface IWeatherBe
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}
