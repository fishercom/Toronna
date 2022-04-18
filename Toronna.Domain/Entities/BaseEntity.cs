using Toronna.Domain.ValueObjects;

namespace Toronna.Domain.Entities;

public class BaseEntity
{
    public GenericId Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
