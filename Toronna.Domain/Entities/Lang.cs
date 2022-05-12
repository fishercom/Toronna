using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Lang : BaseEntity
{
    public string Name { get; set; }
    public Slug Slug { get; set; }
}
