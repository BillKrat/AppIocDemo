using Microsoft.EntityFrameworkCore;

namespace AppIocDemo.DataSource.EF
{
    public static class WebApplicationBuilderEfExtension
    {
        public static WebApplicationBuilder? ConfigureSQLiteForEF(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppIocContext>(options =>
            {
                options.UseSqlite(
                    builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return builder;
        }
    }
}
