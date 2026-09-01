using OmniVet.Application.CRM.Interfaces;
using Microsoft.Data.SqlClient;
using OmniVet.Core.CRM;
using System.Data.Common;

namespace OmniVet.Infrastructure.DataBase;
public sealed class SqlCustomerRepository : ICustomerRepository
{
    private readonly IDataBase _database;

    public SqlCustomerRepository(IDataBase database)
    {
        _database = database;
    }
    public async Task AddAsync(Customer customer)
    {
        DbConnection connection;
        try
        {
          connection = await _database.GetConnectionAsync();
        }
        catch(Exception e)
        {
            throw new Exception($"error al conectar. {e.Message}");
        }
            

        //contenido del dapper
        try
        {

        }
        catch(Exception e)
        {

        }
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