using Microsoft.Extensions.DependencyInjection;

namespace ZoomTrack.Persistence;

public static class PersistenceDependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        return services;
    }
}
