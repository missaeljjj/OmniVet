using Microsoft.Data.SqlClient;
namespace OmniVet.Infrastructure.DataBase;

public interface IDataBase
{
    Task<SqlConnection>  GetConnectionAsync();
}