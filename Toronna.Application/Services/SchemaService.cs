using System;
using Ardalis.GuardClauses;
using Toronna.Application.Interfaces;
using Toronna.Domain.Entities;
using Toronna.Domain.Interfaces.Repositories;
using Toronna.Domain.ValueObjects;

namespace Toronna.Application.Services;

public class SchemaService : IBaseService<Schema, GenericId>
{
    private readonly IBaseRepository<Schema, GenericId> repSchema;
    private readonly IBaseRepository<Field, GenericId> repField;
    public SchemaService(
        IBaseRepository<Schema, GenericId> _repSchema,
        IBaseRepository<Field, GenericId> _repField
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

    public void Delete(GenericId EntityId)
    {
        repSchema.Delete(EntityId);
        repSchema.SaveAll();
    }

    public Schema Find(GenericId EntityId)
    {
        return repSchema.Find(EntityId);
    }

    public List<Schema> List()
    {
        return repSchema.List();
    }

}

