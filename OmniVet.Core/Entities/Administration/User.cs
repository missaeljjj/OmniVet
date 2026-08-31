using OmnitVet.Core.Shared;
using OmnitVet.Core.Exceptions;
using OmniVet.Core.Medical;
using OmniVet.Core.Shared;
using System.Runtime.CompilerServices;

namespace OmnitVet.Core.Admimistration
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
            set => field = (value == "Administrador" || value == "Veterinario" || "Recepcionista")
                ? value
                : throw new AppDomainUnloadedException("El rol no es valido");
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



