using Microsoft.Extensions.DependencyInjection;
using OmniVet.Applications.CRM.Repositories;
using OmniVet.Infrastructure.DataBase;

namespace OmniVet.Infrastructure.Dependencies;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IDataBase,DataBaseConnection>();
        services.AddScoped<ICustomerRepository,SqlCustomerRepository>();
        return services;
    }
}