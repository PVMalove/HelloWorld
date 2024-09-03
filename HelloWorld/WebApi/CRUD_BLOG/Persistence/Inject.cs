using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class Inject
{
    public static IServiceCollection AddPersistence(this IServiceCollection services,  IConfiguration configuration)
    {
        string? connectionString = configuration["DbConnection"];
        services.AddDbContext<BlogDbContext>(options => options.UseNpgsql(connectionString));
        services.AddScoped<IBlogRepository, BlogRepository>();

        return services;
    }
}