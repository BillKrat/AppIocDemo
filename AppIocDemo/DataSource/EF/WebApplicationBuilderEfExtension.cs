using Microsoft.EntityFrameworkCore;

namespace AppIocDemo.DataSource.EF
{
    public static class WebApplicationBuilderEfExtension
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


            //builder.Services.AddDbContext<AppIocContext>(options =>
            //{
            //    options.UseSqlite(
            //        builder.Configuration.GetConnectionString("DefaultConnection"));
            //});

            return builder;
        }
    }
}
