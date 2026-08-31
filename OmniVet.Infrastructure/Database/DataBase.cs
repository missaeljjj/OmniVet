using System.Data;
using Microsoft.Data.SqlClient;

namespace OmniVet.Infrastructure.DataBase;

public sealed class DataBase
{
    //por el momento quedara asi aunq este expuesta pero a futuro se hara que se lea la cadena con un json y luego segun si es github o no lea la correcta u otra
    private readonly string _connectionString = @"Server=tcp:veterinaryclinic.database.windows.net,1433;Initial Catalog=VetClinic;Persist Security 
                                                Info=False;User ID=AdminSql123;Password=VetClinicMM280125.;MultipleActiveResultSets=False;Encrypt=True;
                                                TrustServerCertificate=False;Connection Timeout=30;";
    public async Task<SqlConnection> GetConnectionAsync()
    {
        var connection = new SqlConnection(_connectionString);

        if(connection.State != ConnectionState.Open)
        {
            await connection.OpenAsync();            
        }

        return connection;

    }
}