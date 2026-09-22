using OmniVet.Applications.CRM.DTOs;
using OmniVet.Core.CRM;


namespace OmniVet.Applications.CRM.Mappers;

public static class CustomerMappers
{
    //CustomerDto -> Customer
    public static Customer CustomerDtoToCustomer(this CustomerCommandDto dto)
    => new(0,0,dto.FirstName,dto.SecondName ?? "",dto.FirstLastName,dto.SecondLastName ?? "",dto.Address ?? "",true);

}