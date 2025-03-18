using AppIocDemo.Interfaces;
using AppIocDemo.Models.Entities;

namespace WeatherForecastDemo.Test.Mocks
{
    public class WeatherTestDac : IWeatherDac
    {
        public static string BeachDay = "This is a good day for the beach!";

        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            var returnValue = new List<WeatherForecast>();
            returnValue.Add(new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Summary = BeachDay,
                TemperatureC = 32,
            });


            return returnValue;
        }
    }
}
