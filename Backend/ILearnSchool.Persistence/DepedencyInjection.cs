
using System.Diagnostics;

using ILearnSchool.Core.Interfaces.Authentication;
using ILearnSchool.Core.Interfaces.Services;
using ILearnSchool.Persistence.Authentication;
using ILearnSchool.Persistence.Data;
using ILearnSchool.Persistence.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ILearnSchool.Persistence;

public static class DepedencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(ConnectionSettings.DefaultConnection))
            // for testing purposes
            .EnableSensitiveDataLogging()
            .LogTo(log => Debug.WriteLine(log)));

        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
