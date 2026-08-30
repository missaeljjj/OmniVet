using System;

namespace OmniVet.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id
        {
            get; protected set;
        }
        public DateTime FechaCreacion { get; private set; } = DateTime.Now;

        protected BaseEntity(int id)
        {
            Id = id;
        }
    } 

}