using System;
using Toronna.Domain.Interfaces;
using Toronna.Domain.Interfaces.Repositories;

namespace Toronna.Application.Interfaces;

public interface IBaseService<TEntity, TEntityId>
    : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityId>, IList<TEntity, TEntityId>
{

}

