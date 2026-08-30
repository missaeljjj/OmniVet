using System.Collections.Generic;
using OmniVet.Core.Entities.Replenishment;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        IEnumerable<Supplier> GetActivos();
    }
}
