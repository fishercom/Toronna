using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Article : BaseEntity
{
    public GenericId ArticleId { get; set; }
    public GenericId LangId { get; set; }
    public GenericId? ParentId { get; set; }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Metadata { get; set; }
    public Slug Slug { get; set; }

    public Schema Schema { get; set; }
    public Lang Lang { get; set; }
    public Article? Parent { get; set; }

    public List<Article> Children { get; set; }
}
