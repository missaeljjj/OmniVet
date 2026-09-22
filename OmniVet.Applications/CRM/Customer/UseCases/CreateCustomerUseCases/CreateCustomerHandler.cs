using OmniVet.Applications.CRM.DTOs;
using OmniVet.Applications.CRM.Repositories;
using OmniVet.Applications.CRM.UseCases.CreateCustomerUseCases;
using OmniVet.Applications.Shared.Results;
using OmniVet.Applications.CRM.Mappers;
using OneOf.Types;
using OneOf;

namespace OmniVet.Applications.CRM.UseCases;

public class CreateCustomerHandler(ICustomerRepository repository,CreateCustomerValidator validator)
{
    private readonly ICustomerRepository _repository = repository ?? 
    throw new ArgumentNullException(nameof(repository));

    private readonly CreateCustomerValidator _validator = validator ??
    throw new ArgumentNullException(nameof(validator));


    public async Task<OneOf<Success,ValidationError,AlreadyExists>> Handle(CustomerCommandDto dto)
    {
        var result = await _validator.ValidateAsync(dto);

        if(result.IsT1) return result.AsT1;
        
        if(result.IsT2) return result.AsT2;
                
        var customer = CustomerMappers.CustomerDtoToCustomer(dto);

        await _repository.AddAsync(customer);

        return new Success();
        
    }


    
}