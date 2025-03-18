using AppIocDemo.LayerBusiness.Facades;
using Microsoft.Extensions.DependencyInjection;
using WeatherForecastDemo.Test.Mocks;
using WeatherForecastDemo.Test.Startup;

namespace WeatherForecastDemo.Test
{
    [TestClass]
    public sealed class IntegrationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var provider = TestStartup.GetProvider();

            var facade = provider.GetService<WeatherFacade>();
            var firstRecord = facade?.GetWeatherData().FirstOrDefault();

            Assert.IsNotNull(firstRecord);
            Assert.AreEqual(WeatherTestDac.BeachDay, firstRecord.Summary);
            Assert.AreEqual(32, firstRecord.TemperatureC);
            Assert.AreEqual(89, firstRecord.TemperatureF);

        }


    }
}
