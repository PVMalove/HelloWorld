using BisinessLogic;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public static class Inject
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();
        return services;
    }
}