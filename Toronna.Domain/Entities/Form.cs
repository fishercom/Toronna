using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class Fields : BaseEntity
{
    public string Name { get; set; }
    public Alias Alias { get; set; }

}
