using OmniVet.Applications.General.Repositories;
using OmniVet.Core.General;
using OmniVet.Infrastructure.DataBase;

namespace OmniVet.Infrastructure.General.Identifications;

public class SqlIdentificationRepository(IDataBase database) : IIdentificationRepository
{
    private readonly IDataBase _database = database ?? 
    throw new ArgumentNullException(nameof(database));

    public Task<bool> ExistingIdentification(string identificationNumber)
    {
        throw new NotImplementedException();
    }

    public Task<Identification?> GetByNumberAndTypeAsync(string number, IdentificationType type)
    {
        throw new NotImplementedException();
    }

}