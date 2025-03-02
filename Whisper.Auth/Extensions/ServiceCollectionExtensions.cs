using Whisper.Services.Extensions;

namespace Whisper.Auth.Extensions;

internal static class ServiceCollectionExtensions
{
    internal static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddAuthService(ServiceLifetime.Scoped);
    }
}