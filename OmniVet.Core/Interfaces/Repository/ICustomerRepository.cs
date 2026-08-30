using System;
using System.Collections.Generic;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetNuevos(DateTime desde);
        IEnumerable<Customer> GetVip();
        int ContarMascotasRegistradas();
    }
}