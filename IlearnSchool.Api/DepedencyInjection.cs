using IlearnSchool.Api.Errors;
using IlearnSchool.Api.Mapping;

using ILearnSchool.Core.Models;
using ILearnSchool.Persistence.Data;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;

namespace IlearnSchool.Api;

public static class DepedencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();

        // configure Swagger/OpenAPI
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddSwaggerGen(o =>
        {
            o.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = @"Specify 'Bearer' [space] and then the tokens
                            Example: 'Bearer 23422sfviome'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });
        });

        // configure Authentication
        services.AddAuthentication(o =>
        {
            o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        });

        // configure Identity
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

        // Register Mapster
        services.AddMappings();

        // Register Custom Problem Details Factory
        services.AddSingleton<ProblemDetailsFactory, ILearnSchoolProblemDetailsFactory>();

        return services;
    }
}