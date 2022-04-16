namespace Toronna.Domain.Interfases;

public interface IEdit<TEntity>
{
    TEntity Edit(TEntity Entity);
}

