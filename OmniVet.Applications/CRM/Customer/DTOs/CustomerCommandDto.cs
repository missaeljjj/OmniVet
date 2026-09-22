using OmniVet.Applications.General.DTOs;

namespace OmniVet.Applications.CRM.DTOs;

public record CustomerCommandDto(string FirstName,string? SecondName,string FirstLastName,string? SecondLastName,string? Address,IdentificationCommandDto Identification);