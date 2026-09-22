using Microsoft.Extensions.DependencyInjection;
using OmniVet.Applications.CRM.UseCases;
using OmniVet.Applications.CRM.UseCases.CreateCustomerUseCases;
public static class ApplicationsServiceCollectionExtensions
{
    public static IServiceCollection AddApplications(this IServiceCollection services)
    {
        services.AddTransient<CreateCustomerValidator>();
        services.AddTransient<CreateCustomerHandler>();
        return services;
    }
}