using OmniVet.Core.Entities.General;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person? GetByIdentification(string identification);
    }
}