using AppIocDemo.LayerData.AccessComponents;
using AppIocDemo.Models;

namespace AppIocDemo.LayerBusiness.Facades
{
    public class WeatherFacade
    {
        WeatherDac _dac;
        ILogger _logger;

        public WeatherFacade(WeatherDac dac, ILogger logger)
        {
            _dac = dac;
            _logger = logger;
        }

        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            try
            {
                var data = _dac.GetWeatherData();
                if (data.Count() == 0)
                {
                    _logger.LogWarning("WeatherFacade was expecting data!");
                }
                return data;

            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            }
        }

    }
}
