namespace Toronna.Domain.Interfaces;

public interface IAdd<TEntity>
{
    TEntity Add(TEntity Entity);
}
