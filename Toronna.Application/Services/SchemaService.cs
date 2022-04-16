using System;
using Ardalis.GuardClauses;
using Toronna.Application.Interfaces;
using Toronna.Domain.Entities;
using Toronna.Domain.Interfaces.Repositories;

namespace Toronna.Application.Services;

public class SchemaService : IBaseService<Schema, long>
{
    private readonly IBaseRepository<Schema, long> repSchema;
    private readonly IBaseRepository<Field, long> repField;
    public SchemaService(
        IBaseRepository<Schema, long> _repSchema,
        IBaseRepository<Field, long> _repField
        )
    {
        repSchema = _repSchema;
        repField = _repField;
    }

    public Schema Add(Schema Entity)
    {
        Guard.Against.Null(Entity, nameof(Entity));

        Schema results = repSchema.Add(Entity);

        Entity.Fields.ForEach(field =>
        {
            field.SchemaId = results.Id;
            repField.Add(field);
        });

        repSchema.SaveAll();

        return results;
    }

    public Schema Edit(Schema Entity)
    {
        Guard.Against.Null(Entity, nameof(Entity));

        Schema results = repSchema.Edit(Entity);
        repSchema.SaveAll();

        return results;
    }

    public void Delete(long EntityId)
    {
        repSchema.Delete(EntityId);
        repSchema.SaveAll();
    }

    public Schema Find(long EntityId)
    {
        return repSchema.Find(EntityId);
    }

    public List<Schema> List()
    {
        return repSchema.List();
    }

}

