using OmniVet.Application.CRM.Interfaces;
using OmniVet.Core.CRM;

public sealed class SqlCustomerRepository : ICustomerRepository
{
    public async Task AddAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int key)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Customer customer)
    {
        throw new NotImplementedException();
    }
}