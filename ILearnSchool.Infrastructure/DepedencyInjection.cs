using System.Text;

using ILearnSchool.Core.Interfaces.Infrastructure.Authentication;
using ILearnSchool.Core.Interfaces.Infrastructure.Services;
using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.Models;
using ILearnSchool.Infrastructure.Persistence;
using ILearnSchool.Persistence.Authentication;
using ILearnSchool.Persistence.Data;
using ILearnSchool.Persistence.Persistence;
using ILearnSchool.Persistence.Services;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ILearnSchool.Infrastructure;

public static class DepedencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        // Authentication
        //services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();

        // Configure Authentication
        var jwtSettings = new JwtSettings();
        configuration.Bind(JwtSettings.SectionName, jwtSettings);
        services.AddSingleton(Options.Create(jwtSettings));

        services.AddAuthentication(o =>
        {
            // Set the default scheme to 'Bearer'
            o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(o => o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret))
        });


        // Configure Identity
        var builder = services.AddIdentityCore<ApplicationUser>(options =>
        {
            // for testing purposes
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 1;
        });
        builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
        builder.AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultUI().AddDefaultTokenProviders();

        // Register Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();

        return services;
    }
}