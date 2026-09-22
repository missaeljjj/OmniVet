using Microsoft.Extensions.DependencyInjection;
using OmniVet.AvaloniaUI.ViewModels;
using OmniVet.AvaloniaUI.Views;

public static class PresentationServiceCollectionExtensions
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddSingleton<HomeViewModel>();
        services.AddSingleton<LoginViewModel>();
        services.AddSingleton<CustomerViewModel>();
        services.AddSingleton<AppointmentViewModel>();
        services.AddSingleton<SaleViewModel>();
        services.AddSingleton<PurchaseViewModel>();
        services.AddSingleton<NavigatorViewModel>();
        services.AddSingleton<MainViewModel>();
        return services;
    }
}