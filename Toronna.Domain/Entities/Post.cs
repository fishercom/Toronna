using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Post : BaseEntity
{
    public long? ParentId { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Slug Slug { get; set; }

    public Schema Schema { get; set; }
    public Post? Parent { get; set; }

    public List<Metadata> Metadata { get; set; }
    public List<Post> Children { get; set; }

}
