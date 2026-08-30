using System;
using System.Collections.Generic;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IPetRepository : IRepository<Pet>
    {
        IEnumerable<Pet> GetByCustomer(int customerId);
        IEnumerable<Pet> GetNuevosPacientes(DateTime desde);
    }
}