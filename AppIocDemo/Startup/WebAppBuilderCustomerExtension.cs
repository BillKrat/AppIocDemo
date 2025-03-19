using AppIocDemo.BusinessLayer.Components;
using AppIocDemo.BusinessLayer.Facades;
using AppIocDemo.DataLayer.AccessComponents;
using AppIocDemo.LayerBusiness.Components;
using AppIocDemo.LayerBusiness.Entities;
using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.Startup
{
    public static class WebAppBuilderCustomerExtension
    {
        public static WebApplicationBuilder? ConfigureCustomers(
            this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddSingleton<ScopeService>();
            services.AddSingleton<ScopedUser>();
            services.AddSingleton<IUserConfig, UserConfig>();
            services.AddSingleton<ICustomerFacade, CustomerFacade>();
            services.AddSingleton<ICustomerDac, CustomerDac>();
            services.AddSingleton<ICustomerBe, CustomerBe>();

            return builder;
        }
    }
}
