using System.Collections.Generic;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : Entities.BaseEntity
    {
       public abstract void T GetById(int id);
       public abstract IEnumerable<T> GetAll();
       public abstract void Add(T entity);
       public abstract void Update(T entity);
        public abstract void Delete(int id);
    }
}