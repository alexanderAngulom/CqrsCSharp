using Microsoft.EntityFrameworkCore;
using Valhalla.Infrastructure.Context;

namespace Valhalla.Api.Config.DataBase
{
    public static class DbContextConfiguration
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ValhallaContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
