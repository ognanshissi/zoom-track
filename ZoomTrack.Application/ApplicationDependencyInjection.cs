using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ZoomTrack.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services) 
    {
        var applicationAssembly = typeof(ApplicationDependencyInjection).Assembly;

        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(applicationAssembly));
        services.AddValidatorsFromAssembly(applicationAssembly);
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services; 
    }
}
