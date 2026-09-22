
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OmniVet.Applications.CRM.DTOs;
using OmniVet.Applications.CRM.UseCases;
using OmniVet.Applications.General.DTOs;

namespace OmniVet.AvaloniaUI.ViewModels;

public partial class CustomerViewModel : ViewModelBase
{
   
    
    /*

     private readonly CreateCustomerHandler _useCase;
     
    public CustomerViewModel(CreateCustomerHandler UseCase)
    {
        _useCase = UseCase  ?? throw new ArgumentNullException(nameof(UseCase));
    }
    */
    [ObservableProperty]
    private bool _generalIsVisible = true;

    [ObservableProperty]
    private bool _createNewCustomerIsVisible = false;

    [ObservableProperty]
    private string _errorMessage = string.Empty;

    [ObservableProperty]
    private bool _hasError = false;

    [ObservableProperty]
    private string _firstName = string.Empty;

    [ObservableProperty]
    private string? _secondName;

    [ObservableProperty]
    private string _firstLastName = string.Empty;

    [ObservableProperty]
    private string? _secondLastName;

    [ObservableProperty]
    private string? _address;

    [ObservableProperty]
    private string _identificationNumber = string.Empty;

    [ObservableProperty]
    private string? _selectedIdentificationType;

    [ObservableProperty]
    private bool _isLoading = false;
    public ObservableCollection<string> IdentificationTypes { get; } = new()
    {
        "Cédula de Identidad",
        "Pasaporte",
        "RUC",
        "Cédula de Extranjería"
    };

 

    [RelayCommand]
    private void CreateNewCustomerShow()
    {
        ClearForm();
        GeneralIsVisible = false;
        CreateNewCustomerIsVisible = true;
    }

    [RelayCommand]
    private async Task SaveCustomer()
    {
        if (!ValidateForm())
        {      
            
        }



        try
        {
            /*
            var identificacion = new IdentificationCommandDto(IdentificationNumber,1);

            var customer = new CustomerCommandDto(FirstName,SecondName,FirstLastName,SecondLastName,Address,identificacion);

           var result = await _useCase.Handle(customer);
            
            result.Switch
            (
                Success =>
                {
                    ErrorMessage = string.Empty;
                    ShowGeneralView();

                },
                AlreadyExists =>
                {
                    ErrorMessage = "algo existe ya";
                },

                ValidationError =>
                {
                    ErrorMessage = "Ocyrrio algo inesperado xd";
                }

            );
            

        */


        }
        catch (Exception ex)
        {
            SetError($"Error al guardar el cliente: {ex.Message}");
        }
    }

    [RelayCommand]
    private void Cancel()
    {
        ShowGeneralView();
    }

    private void ShowGeneralView()
    {
        ClearForm();
        CreateNewCustomerIsVisible = false;
        GeneralIsVisible = true;
    }

    private void ClearForm()
    {
        FirstName = string.Empty;
        SecondName = null;
        FirstLastName = string.Empty;
        SecondLastName = null;
        Address = null;
        IdentificationNumber = string.Empty;
        SelectedIdentificationType = null;
        ErrorMessage = string.Empty;
        HasError = false;
    }

    private bool ValidateForm()
    {
        if (string.IsNullOrWhiteSpace(FirstName))
        {
            SetError("El primer nombre es obligatorio.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(FirstLastName))
        {
            SetError("El primer apellido es obligatorio.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(SelectedIdentificationType))
        {
            SetError("Debe seleccionar un tipo de identificación.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(IdentificationNumber))
        {
            SetError("El número de identificación es obligatorio.");
            return false;
        }

        HasError = false;
        ErrorMessage = string.Empty;
        return true;
    }

    private void SetError(string message)
    {
        ErrorMessage = message;
        HasError = true;
    }
}