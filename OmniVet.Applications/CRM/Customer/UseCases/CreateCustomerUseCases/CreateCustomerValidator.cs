using OneOf;
using OneOf.Types;
using OmniVet.Applications.CRM.Repositories;
using OmniVet.Applications.Shared.Results;
using OmniVet.Applications.CRM.DTOs;
using OmniVet.Applications.General.Repositories;

namespace OmniVet.Applications.CRM.UseCases.CreateCustomerUseCases;

public class CreateCustomerValidator(ICustomerRepository customerRepository, IIdentificationRepository identificationRepository)
{
    private readonly ICustomerRepository _customerRepository = customerRepository ?? 
    throw new ArgumentNullException(nameof(customerRepository));

    private readonly IIdentificationRepository _identificationRepository = identificationRepository
    ?? throw new ArgumentNullException(nameof(identificationRepository));

    public async Task<OneOf<Success, ValidationError, AlreadyExists>> ValidateAsync(CustomerCommandDto dto)
    {
        if(string.IsNullOrWhiteSpace(dto.FirstName))
            return new ValidationError("El primer nombre es un campo obligatorio."); 

        if(string.IsNullOrWhiteSpace(dto.FirstLastName))
            return new ValidationError("El primer apellido es un campo obligatorio");

        if(dto.Identification is null)  
            return new ValidationError("La identificación es un campo obligatorio");

        var identificationExists = _identificationRepository.ExistingIdentification(dto.Identification.IdentificationNumber);
        var existingCustomer = _customerRepository.ExistingCustomer(dto.Identification.IdentificationNumber);

        await Task.WhenAll(identificationExists,existingCustomer);

        if(identificationExists.Result && existingCustomer.Result)
            return new AlreadyExists("El cliente ya se encuentra registrado");

        return new Success();
    }
}
