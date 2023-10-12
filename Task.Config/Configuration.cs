using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Task.Database;
using Task.Repository;
using Task.Repository.Abstraction;
using Task.Services;
using Task.Services.Abstraction;
namespace Task.Config
{
    public static class Configuration
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection Service, IConfiguration configuration)
        {
            Service.AddScoped<IProductRepository, ProductRepository>();
            Service.AddScoped<IProductService, ProductService>();
            Service.AddDbContext<ApplicationDbContext>(
                option =>
                {
                    option.UseSqlServer("Server=(local); Database=Task; Trusted_Connection=true;TrustServerCertificate=True;");
                    option.UseSqlServer(connectionString => { configuration.GetConnectionString("DefaultConnection"); });
                });
            return Service;
        }
    }
}