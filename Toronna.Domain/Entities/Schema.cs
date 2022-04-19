using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Schema : BaseEntity
{
    public GenericId SiteId { get; set; }
    public GenericId? ParentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public Alias Alias { get; set; }
    public PostType PostType { get; set; }

    public Schema? Parent { get; set; }
    public Site Site { get; set; }

    public List<Post> Posts { get; set; }
    public List<Field> Fields { get; set; }

}


