using Microsoft.Extensions.DependencyInjection;
using Whisper.Services.AuthService;

namespace Whisper.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddAuthService(this IServiceCollection services, ServiceLifetime serviceLifeTime)
    {
        switch (serviceLifeTime)
        {
            case ServiceLifetime.Singleton:
                services.AddSingleton<IAuthService, AuthService.AuthService>();
                break;

            case ServiceLifetime.Scoped:
                services.AddScoped<IAuthService, AuthService.AuthService>();
                break;

            case ServiceLifetime.Transient:
                services.AddTransient<IAuthService, AuthService.AuthService>();
                break;

            default:
                throw new ArgumentOutOfRangeException
                    (
                    nameof(serviceLifeTime),
                    serviceLifeTime,
                    "Invalid service lifetime. Only Singleton, Scoped and Transient are supported."
                    );
        }
    }
}