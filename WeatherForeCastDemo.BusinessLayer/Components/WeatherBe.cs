using AppIocDemo.Models.Entities;
using WeatherForecastDemo.Model.Interfaces;

namespace WeatherForeCastDemo.BusinessLayer.Components
{
    public class WeatherBe(IWeatherDac dac) : IWeatherBe
    {
        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            return dac.GetWeatherData();
        }
    }
}
