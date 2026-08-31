using System.Collections.Generic;
using OmniVet.Core.Shared;

namespace OmniVet.Application.Shared;

public interface IRepository<TEntity,TKey> where TEntity : class, IEntity<TKey>
{
    Task AddAsync(TEntity entity);
    Task DeleteAsync(TKey key);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task UpdateAsync(TEntity entity);

}
