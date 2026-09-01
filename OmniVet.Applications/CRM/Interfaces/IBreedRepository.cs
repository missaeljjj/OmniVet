using OmniVet.Applications.Shared;  
using OmniVet.Core.CRM;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IBreedRepository : IRepository<Breed,int>
    {
        IEnumerable<Breed> GetByAnimal(int animalId);
    }
}