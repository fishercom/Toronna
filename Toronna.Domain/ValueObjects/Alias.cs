namespace Toronna.Domain.ValueObjects;

public class Alias
{
    private readonly string _alias;
    public Alias(string alias)
    {
        _alias = alias;
    }

    public string Value()
    {
        return _alias;
    }
}


