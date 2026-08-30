using System.Collections.Generic;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IBreedRepository : IRepository<Breed>
    {
        IEnumerable<Breed> GetByAnimal(int animalId);
    }
}