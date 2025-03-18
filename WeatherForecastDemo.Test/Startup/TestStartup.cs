using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace WeatherForecastDemo.Test.Startup
{
    public class TestStartup
    {

        public static IServiceProvider GetProvider()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.ConfigureWeatherForecast();
            IHost host = builder.Build();

            IServiceProvider? provider = host.Services.GetService<IServiceProvider>();

            return provider;
            //host.Run();
        }
    }
}
