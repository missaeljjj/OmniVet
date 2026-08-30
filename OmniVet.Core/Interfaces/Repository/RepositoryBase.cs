using System;
using System.Collections.Generic;

namespace OmniVet.Core.Interfaces.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : Entities.BaseEntity
    {
        public void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            GuardarEnOrigenDeDatos(entity);
        }

        protected abstract void GuardarEnOrigenDeDatos(T entity);

        public abstract T GetById(int id);
        public abstract IEnumerable<T> GetAll();
        public abstract void Update(T entity);
        public abstract void Delete(int id);
    }
}