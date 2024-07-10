using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProfessorAssignmentApi.Infrastructure.Repositories;

namespace ProfessorAssignmentApi.Infrastructure;

/// <summary>
/// Represents a static class for dependency injection configuration.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Extension method to register infrastructure services required by the application.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> instance representing the application's configuration.</param>
    /// <returns>The modified <see cref="IServiceCollection"/> instance with added services.</returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IProfessorRepository, ProfessorRepository>();
        return services;
    }
}
