using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Form : BaseEntity
{
    public string Name { get; set; }
    public Alias Alias { get; set; }

}
