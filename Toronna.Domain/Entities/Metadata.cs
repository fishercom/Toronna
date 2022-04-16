using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Metadata : BaseEntity
{
    public long PostId { get; set; }
    public long FieldId { get; set; }
    public string Value { get; set; } = string.Empty;
    public Field Field { get; set; }
    public Post Post { get; set; }

}
