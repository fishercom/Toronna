using System;
using Toronna.Application.Interfaces;
using Toronna.Domain.Entities;
using Toronna.Domain.Interfaces.Repositories;

namespace Toronna.Application.Services;

public class SchemaService : IBaseService<Schema, long>
{
    private readonly IBaseRepository<Schema, long> repository;
    public SchemaService(IBaseRepository<Schema, long> _repository)
    {
        repository = _repository;
    }

    public Schema Add(Schema Entity)
    {
        //throw new NotImplementedException();

        Schema results = repository.Add(Entity);
        repository.SaveAll();

        return results;
    }

    public void Delete(long EntityId)
    {
        throw new NotImplementedException();
    }

    public Schema Edit(Schema Entity)
    {
        throw new NotImplementedException();
    }

    public Schema Find(long EntityId)
    {
        throw new NotImplementedException();
    }

    public List<Schema> List()
    {
        throw new NotImplementedException();
    }

    public void SaveAll()
    {
        throw new NotImplementedException();
    }
}

