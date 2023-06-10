using Microsoft.Extensions.DependencyInjection;

namespace ILearnSchool.Core;

public static class DepedencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DepedencyInjection).Assembly));

        return services;
    }
}
