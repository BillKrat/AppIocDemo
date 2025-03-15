using AppIocDemo.Interfaces;
using AppIocDemo.LayerBusiness.Components;
using AppIocDemo.LayerBusiness.Entities;
using AppIocDemo.LayerBusiness.Facades;
using AppIocDemo.LayerData.AccessComponents;

namespace AppIocDemo.DataSource.EF
{
    public static class WebApplicationBuilderCustomerExtension
    {
        public static WebApplicationBuilder? ConfigureCustomers(
            this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddSingleton<ScopeService>();
            services.AddSingleton<ScopedUser>();
            services.AddSingleton<IConfig, Config>();
            services.AddSingleton<ICustomerFacade, CustomerFacade>();
            services.AddSingleton<ICustomerDac, CustomerDac>();
            services.AddSingleton<ICustomerBe, CustomerBe>();

            return builder;
        }
    }
}
