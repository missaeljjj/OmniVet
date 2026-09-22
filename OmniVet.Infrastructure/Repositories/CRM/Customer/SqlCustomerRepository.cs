using OmniVet.Applications.CRM.Repositories;
using Microsoft.Data.SqlClient;
using OmniVet.Core.CRM;
using System.Data.Common;
using OmniVet.Infrastructure.Shared;
using OneOf.Types;

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
            throw new DataBaseConnectionException($"Error al conectar con la base de datos {e.Message}");
        }
        
        //contenido del dapper
        try
        {
                
        }
        catch
        {
            throw new DataBaseOperationException("Algo inesperado ocurrio durante el proceso. Error de operacion");
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


    public Task<IEnumerable<(Customer, int QuantityOfPurchases)>> GetCustomerWithQuantityOfPurchases()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ExistingCustomer(string IdentificationNumber)
    {
        if(IdentificationNumber == "001-241007-1039B")
        {
            return true;
        }

        return false;
    }
 
}