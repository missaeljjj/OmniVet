using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using OmniVet.AvaloniaUI.ViewModels;
using OmniVet.AvaloniaUI.Views;
using System;
using OmniVet.Infrastructure.Dependencies;

namespace OmniVet.AvaloniaUI;

public partial class App : Application
{
    public static IServiceProvider ServiceProvider {get; private set;} = null!;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var services = new ServiceCollection();

        services.AddInfrastructure();
        services.AddApplications();
        services.AddPresentation();
        

        ServiceProvider = services.BuildServiceProvider();


        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindow = new MainWindow()
            {
                DataContext = ServiceProvider.GetRequiredService<MainViewModel>()
            };

            desktop.MainWindow = mainWindow; 
            

        }

        base.OnFrameworkInitializationCompleted();
    }
}