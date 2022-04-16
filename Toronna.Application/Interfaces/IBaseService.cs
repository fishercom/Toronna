using System;

using Toronna.Domain.Interfaces.Repositories;

namespace Toronna.Application.Interfaces;

public interface IBaseService<TEntity, TEntityId>
    : IBaseRepository<TEntity, TEntityId>
{

}

