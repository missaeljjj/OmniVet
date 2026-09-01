using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;  
using System.Runtime.CompilerServices;

namespace OmniVet.Core.Administration
{
    public class User : IEntity<int>
    {
        public int Id { get; }

        public int? IdVet { get; set; }

        public string UserName
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new AppDomainUnloadedException("El nombre del usuario es obligatorio.");  
        }
        public string UserPassword
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new AppDomainUnloadedException("La contraseña es obligatoria.");

        } 
        public string Role
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new AppDomainUnloadedException("El rol es obligatorio.");
        }
        public bool Status { get; set; } = true;

        public User  (int? idVet, string userName, string userPassword, string role)
        {
            IdVet = idVet;
            UserName = userName;
            UserPassword = userPassword;
            Role = role;
        }
    }
}



