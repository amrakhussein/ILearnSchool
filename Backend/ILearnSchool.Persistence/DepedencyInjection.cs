
using System.Diagnostics;

using ILearnSchool.Persistence.Data;
using ILearnSchool.Persistence.Data.Constants;

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

        return services;
    }
}
