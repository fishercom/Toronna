using System;
namespace Toronna.Domain.Interfaces.Repositories;

public interface IBaseRepository<TEntity, TEntityId>
    : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityId>, IList<TEntity, TEntityId>, ITransaction
{

}

