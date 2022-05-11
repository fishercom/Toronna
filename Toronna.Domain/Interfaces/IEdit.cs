namespace Toronna.Domain.Interfaces;

public interface IEdit<TEntity>
{
    TEntity Edit(TEntity entity);
}

