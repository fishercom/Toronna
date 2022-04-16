using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Field : BaseEntity
{
    public long SchemaId { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Attributes { get; set; } = string.Empty;
    public Alias Alias { get; set; }
    public FieldType FieldType { get; set; }

    public Schema Schema { get; set; }

}
