using AppIocDemo.Models.Entities;
using WeatherForecastDemo.Model.Interfaces;

namespace WeatherForeCastDemo.BusinessLayer.Facades
{
    public class WeatherFacade
    {
        IWeatherBe _be;

        public WeatherFacade(IWeatherBe be)
        {
            _be = be;
        }

        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            var results = _be.GetWeatherData();
            return results;
        }

    }
}
