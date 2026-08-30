using System;
using OmniVet.Core.Entities.General;

namespace OmniVet.Core.Entities.Replenishment
{
    public class Supplier : Entities.BaseEntity
    {
        public int IdPerson { get; private set; }
        public Person? Person { get; private set; }
        public bool Status { get; private set; }

        public Supplier(int id, int idPerson, Person? person = null) : base(id)
        {
            if (idPerson <= 0)
                throw new ArgumentException("IdPerson inválido");

            IdPerson = idPerson;
            Person = person;
            Status = true;
        }

        public void Activar() => Status = true;
        public void Desactivar() => Status = false;
    }
}