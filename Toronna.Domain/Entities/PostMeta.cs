using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class PostMeta : BaseEntity
{
    public GenericId PostId { get; set; }
    public GenericId FieldId { get; set; }
    public string Value { get; set; } = string.Empty;
    public Field Field { get; set; }
    public Post Post { get; set; }

}
