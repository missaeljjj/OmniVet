using System;
using System.Linq;
using OmniVet.Core.Entities.Medical;

namespace OmniVet.Core.Entities.Administration
{
    public class User : Entities.BaseEntity
    {
        private static readonly string[] RolesValidos = { "Admin", "Veterinario", "Recepcionista" };

        public int? IdVet { get; private set; }
        public Vet? Vet { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; } 
        public string Role { get; private set; }
        public bool Status { get; private set; }

        public User(int id, string userName, string userPasswordHash, string role, int? idVet = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("El usuario es obligatorio");
            if (string.IsNullOrWhiteSpace(userPasswordHash))
                throw new ArgumentException("La contraseña es obligatoria");
            if (!RolesValidos.Contains(role))
                throw new ArgumentException($"Rol inválido: {role}");

            UserName = userName;
            UserPassword = userPasswordHash;
            Role = role;
            IdVet = idVet;
            Status = true;
        }

        public void CambiarPassword(string nuevoHash)
        {
            if (string.IsNullOrWhiteSpace(nuevoHash))
                throw new ArgumentException("La nueva contraseña no puede estar vacía");
            UserPassword = nuevoHash;
        }

        public void Activar() => Status = true;
        public void Desactivar() => Status = false;
    }
}