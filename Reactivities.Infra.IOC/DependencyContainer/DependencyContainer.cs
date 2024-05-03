using Microsoft.Extensions.DependencyInjection;
using Reactivities.Application.Services.Implementation;
using Reactivities.Application.Services.Interfaces;
using Reactivities.Domain.Interfaces;
using Reactivities.Infra.Data.Repositories;

namespace Reactivities.Infra.IOC.DependencyContainer;
public static class DependencyContainer
{
    public static void RegisterServices(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IActivitiesRepository, ActivitiesRepository>();


        // services
        services.AddScoped<IActivitiesService, ActivitiesService>();
    }
}
