using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Field : BaseEntity
{
    public GenericId SchemaId { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Attributes { get; set; } = string.Empty;
    public Slug Slug { get; set; }
    public FieldType FieldType { get; set; }

    public Schema Schema { get; set; }

}
