using AOTE.Framework.CrossCutting.Interfaces;
using AppIocDemo.Interfaces;
using AppIocDemo.LayerBusiness.Components;
using AppIocDemo.LayerBusiness.Entities;
using AppIocDemo.LayerBusiness.Facades;
using AppIocDemo.LayerData.AccessComponents;

namespace AppIocDemo.DataSource.EF
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
