using OmniVet.Core.Exceptions;
using OmnitVet.Core.Shared;

namespace OmnitVet.Core.General;

public class Identifications : IEntity<int>
{
    public int Id { get; }
    public int PersonId { get; set; }
    public int IdentificationTypeId { get; set; }

    public string IdentificationNumber
    {
        get;
        private set => field = !string.IsNullOrWhiteSpace(value) switch
        {
            true => throw new DomainException("El numero de identificacion no puede estar vacio"),
            _ => value.Trim()
        };
    }
    public Identifications(int personId, int identificationTypeId, string identificationNumber)
    {
        this.Id = personId;
        IdentificationTypeId = identificationTypeId;
        IdentificationNumber = identificationNumber;

    }
}
