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

    public Schema Add(Schema entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Schema results = repSchema.Add(entity);

        entity.Fields.ForEach(field =>
        {
            field.SchemaId = results.Id;
            repField.Add(field);
        });

        repSchema.SaveAll();

        return results;
    }

    public Schema Edit(Schema entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Schema results = repSchema.Edit(entity);
        repSchema.SaveAll();

        return results;
    }

    public void Delete(GenericId entityId)
    {
        repSchema.Delete(entityId);
        repSchema.SaveAll();
    }

    public Schema Find(GenericId entityId)
    {
        return repSchema.Find(entityId);
    }

    public List<Schema> List()
    {
        return repSchema.List();
    }

}

