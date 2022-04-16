namespace Toronna.Domain.Interfases;

public interface IAdd<TEntity>
{
    TEntity Add(TEntity Entity);
}
