using System.Collections.Generic;
using OmniVet.Core.Entities.Medical;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IVetRepository : IRepository<Vet>
    {
        IEnumerable<Vet> GetActivos();
        IEnumerable<Specialty> GetEspecialidades(int vetId);
    }
}