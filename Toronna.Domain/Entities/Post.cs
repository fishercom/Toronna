using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Post : BaseEntity
{
    public GenericId SchemaId { get; set; }
    public GenericId LangId { get; set; }
    public GenericId? ParentId { get; set; }

    public string Title { get; set; }
    public string Content { get; set; }
    public Slug Slug { get; set; }

    public Schema Schema { get; set; }
    public Lang Lang { get; set; }
    public Post? Parent { get; set; }

    public List<PostMeta> PostMeta { get; set; }
    public List<Post> Children { get; set; }

}
