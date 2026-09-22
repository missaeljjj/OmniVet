using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace OmniVet.AvaloniaUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel(NavigatorViewModel navigator, LoginViewModel login)
    {
        _navigator = navigator ?? throw new ArgumentNullException(nameof(navigator));

        login.LoginSucceeded += NavigateToHomeAfterLogin;

        CurrentView = login;
    }

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    [ObservableProperty]
    public partial bool IsLoggedIn { get; set; }

    private readonly NavigatorViewModel _navigator;

    private void NavigateToHomeAfterLogin()
    {
        IsLoggedIn = true;
        CurrentView = _navigator;
        _navigator.GoToHome();

    }

}