using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OmniVet.AvaloniaUI.ViewModels;

public partial class NavigatorViewModel : ViewModelBase
{
    private readonly HomeViewModel _home;
    private readonly CustomerViewModel _customer;
    private readonly AppointmentViewModel _appointment;
    private readonly SaleViewModel _sale;
    private readonly PurchaseViewModel _purchase;
    private readonly LoginViewModel _login;

    public NavigatorViewModel    
    (
     HomeViewModel home,
     CustomerViewModel customer,
     AppointmentViewModel appointment, 
     SaleViewModel sale, 
     PurchaseViewModel purchase,
     LoginViewModel login
     
    )
    {
        
        _home = home ?? throw new ArgumentNullException(nameof(home));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
        _sale = sale ?? throw new ArgumentNullException(nameof(sale));
        _purchase = purchase ?? throw new ArgumentNullException(nameof(purchase));
        _login   = login ?? throw new ArgumentNullException(nameof(login));
    }

    [ObservableProperty]
    public partial ViewModelBase? CurrentView { get; set; }

    [RelayCommand]
    public void GoToLogin() => ChangeView(_login);
    public void GoToHome() => ChangeView(_home);
    [RelayCommand]
    public void GoToCustomers() => ChangeView(_customer);
    [RelayCommand]
    public void GoToAppointments() => ChangeView(_appointment);
    [RelayCommand]
    public void GoToSales() => ChangeView(_sale);
    [RelayCommand]
    public void GoToPurchases() => ChangeView(_purchase);

    private void ChangeView(ViewModelBase newView) => ChangeView2(newView);

    private void ChangeView2(ViewModelBase newView) => CurrentView = newView;
}