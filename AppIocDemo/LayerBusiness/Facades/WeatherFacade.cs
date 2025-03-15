using AppIocDemo.LayerData.AccessComponents;
using AppIocDemo.Models;

namespace AppIocDemo.LayerBusiness.Facades
{
    public class WeatherFacade
    {
        WeatherDac _dac;

        public WeatherFacade(WeatherDac dac)
        {
            _dac = dac;
        }

        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            var data = _dac.GetWeatherData();
            return data;
        }

    }
}
