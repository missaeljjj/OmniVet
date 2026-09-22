using  OmniVet.Core.General;
using OmniVet.Applications.General.DTOs;
namespace OmniVet.Applications.General.Mappers;

public static class IdentificationMapper
{
    public static Identification IdentificationCommandDtoToIdentification(this IdentificationCommandDto dto) 
    => new(0,dto.IdentificationTypeId,dto.IdentificationNumber);
        
    
}