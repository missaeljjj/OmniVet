using OmniVet.Core.Entities.Administration;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User? GetByUserName(string userNameOrEmail);
        bool ValidarCredenciales(string userNameOrEmail, string password);
    }
}