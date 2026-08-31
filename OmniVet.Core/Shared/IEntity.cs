namespace OmniVet.Core.Shared;

/// <summary>
/// Represents inheritents as uniques.
/// It works to give a special value and distingish them from others of same kind. 
/// </summary>
/// <typeparam name="TKey"></typeparam>
public interface IEntity<TKey>
{
    /// <summary>
    /// Unique value of entity.
    /// </summary>
    /// <remarks>
    /// This value shouldn't change once assigned.
    /// </remarks>
    TKey Id{get;}
}