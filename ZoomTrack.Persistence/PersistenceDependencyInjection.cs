using Microsoft.Extensions.DependencyInjection;
using ZoomTrack.Application.Contracts.Persistence;
using ZoomTrack.Persistence.Repositories;

namespace ZoomTrack.Persistence;

public static class PersistenceDependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        return services;
    }
}
