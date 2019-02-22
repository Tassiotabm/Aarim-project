using Aarim.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Aarim.Back.Extensions
{
    public static class DbExtension
    {
        public static void AddDbServices(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<DomainDbContext>(options =>
                options.UseNpgsql(configuration.GetSection("DefaultConnection").Value,
                    x => x.MigrationsAssembly("Aarim.Migrations")));
        }

        public static void UseMigration(this IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (env.IsDevelopment())
                {
                    serviceScope.ServiceProvider.GetService<DomainDbContext>().Database.Migrate();
                }
            }

            Task.Run(async () => await Seed(app));
        }

        public static async Task Seed(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //serviceScope.ServiceProvider.GetService<DomainDbContext>().EnsureSeedData();
            }
        }
    }
}
