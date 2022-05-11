using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Form : BaseEntity
{
    public GenericId SiteId { get; set; }
    public string Name { get; set; }
    public Alias Alias { get; set; }

    public Site Site { get; set; }
}
