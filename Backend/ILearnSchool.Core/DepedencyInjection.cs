using ILearnSchool.Core.Services.Authentication;

using Microsoft.Extensions.DependencyInjection;

namespace ILearnSchool.Core;

public static class DepedencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
