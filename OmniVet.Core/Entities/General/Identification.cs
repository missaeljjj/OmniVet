using OmniVet.Core.Exceptions;
using OmniVet.Core.Shared;

namespace OmniVet.Core.General;

public class Identification : IEntity<int>
{
    public int Id { get; }
    public int PersonId { get; set; }
    public int IdentificationTypeId { get; set; }

    public string IdentificationNumber
    {
        get;
        private set => field = string.IsNullOrWhiteSpace(value) switch
        {
            true => throw new DomainException("El numero de identificacion no puede estar vacio"),
            _ => value.Trim()
        };
    }
    public Identification(int id, int identificationTypeId, string identificationNumber)
    {
        Id = id;
        IdentificationTypeId = identificationTypeId;
        IdentificationNumber = identificationNumber;

    }
}
