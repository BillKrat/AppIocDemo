using AppIocDemo.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace AppIocDemo.Startup
{
    public static class WebAppBuilderEfExtension
    {
        public static WebApplicationBuilder? ConfigureSQLiteForEF(
            this WebApplicationBuilder builder)
        {
            var connectionString = builder
                .Configuration["ConnectionStrings:DefaultConnection"];

            builder.Services.AddTransient<AppIocContext>(provider =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppIocContext>();
                optionsBuilder.UseSqlite(connectionString);
                return new AppIocContext(optionsBuilder.Options);
            });

            // We could set the following to Singleton (second parameter to 
            // AddDbContext) but this would mean all request would share the 
            // same context - our work around will be to create a new context
            // each request.

            //builder.Services.AddDbContext<AppIocContext>(options =>
            //{
            //    options.UseSqlite(
            //        builder.Configuration.GetConnectionString("DefaultConnection"));
            //});

            return builder;
        }
    }
}
