using OmniVet.Core.Shared;

namespace OmniVet.Core.General;

public class IdentificationType : IEntity<int>
{
    public int Id {get;}

    public string IdentificationTypeName{get;} = "";

    public IdentificationType(int id,string identificationTypeName)
    {
        Id = id;
        IdentificationTypeName = identificationTypeName;
    }
}