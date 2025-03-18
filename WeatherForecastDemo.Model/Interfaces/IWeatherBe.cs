using AppIocDemo.Models.Entities;

namespace WeatherForecastDemo.Model.Interfaces
{
    public interface IWeatherBe
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}
