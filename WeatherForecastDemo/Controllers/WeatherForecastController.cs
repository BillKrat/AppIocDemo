using AppIocDemo.LayerBusiness.Facades;
using AppIocDemo.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AppIocDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private WeatherFacade _facade;

        public WeatherForecastController(WeatherFacade facade)
        {
            _facade = facade;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _facade.GetWeatherData();
            return result;
        }
    }
}
