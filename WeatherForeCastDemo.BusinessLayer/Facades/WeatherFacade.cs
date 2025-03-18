using AppIocDemo.Interfaces;
using AppIocDemo.Models.Entities;

namespace AppIocDemo.LayerBusiness.Facades
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
