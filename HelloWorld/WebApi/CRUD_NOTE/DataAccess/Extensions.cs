using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class Extensions
{
    // Этот метод расширения AddDataAccess добавляет необходимые сервисы для работы с базой данных в приложении.
    public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        // Здесь мы добавляем сервис AppContext в контейнер зависимостей.
        // AppContext является контекстом базы данных, который используется для взаимодействия с базой данных.
        services.AddDbContext<AppContext>(x =>
        {
            // Здесь мы настраиваем параметры подключения к базе данных.
            // В данном случае, мы используем PostgreSQL базу данных
            x.UseNpgsql(configuration.GetConnectionString("DbConnection")); 
        });

        return services;
    }
}