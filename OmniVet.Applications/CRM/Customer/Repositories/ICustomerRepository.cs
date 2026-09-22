using OmniVet.Applications.Shared;
using OmniVet.Core.CRM;

namespace OmniVet.Applications.CRM.Repositories;
public interface ICustomerRepository : IRepository<Customer,int>
{
    Task<IEnumerable<(Customer,int QuantityOfPurchases)>> GetCustomerWithQuantityOfPurchases();

    Task<bool> ExistingCustomer(string IdentificationNumber);
    
}
    