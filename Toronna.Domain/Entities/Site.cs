namespace Toronna.Domain.Entities;

public class Site : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

