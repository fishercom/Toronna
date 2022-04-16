using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Schema : BaseEntity
{
    public long SiteId { get; set; }
    public long ParentId { get; set; }
    public Alias? Alias { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Fields { get; set; } = string.Empty;

    public Schema? Parent { get; set; }
    public Site Site { get; set; }

    public Schema(Site site)
    {
        Site = site;
    }
}


