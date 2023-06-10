using ILearnSchool.Core.Interfaces.Authentication;
using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.Interfaces.Services;
using ILearnSchool.Persistence.Authentication;
using ILearnSchool.Persistence.Persistence;
using ILearnSchool.Persistence.Services;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ILearnSchool.Persistence;

public static class DepedencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}