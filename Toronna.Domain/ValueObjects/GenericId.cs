namespace Toronna.Domain.ValueObjects;

public class GenericId
{
    private readonly Guid _value;
    public GenericId(Guid value)
    {
        _value = value;
    }

    public Guid Value()
    {
        return _value;
    }
}

