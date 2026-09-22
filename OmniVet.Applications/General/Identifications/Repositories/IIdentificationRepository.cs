using OmniVet.Applications.Shared;
using OmniVet.Core.General;

namespace OmniVet.Applications.General.Repositories;

public interface IIdentificationRepository
{
     Task<bool> ExistingIdentification(string identificationNumber);
    Task<Identification?> GetByNumberAndTypeAsync(string number, IdentificationType type);

}