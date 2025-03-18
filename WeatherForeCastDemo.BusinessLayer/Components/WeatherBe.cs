using AppIocDemo.Interfaces;
using AppIocDemo.Models;
using AppIocDemo.Models.Entities;

namespace AppIocDemo.LayerBusiness.Entities
{
    public class WeatherBe(IWeatherDac dac) : IWeatherBe
    {
        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            return dac.GetWeatherData();
        }
    }
}
