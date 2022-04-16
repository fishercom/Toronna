namespace Toronna.Domain.ValueObjects;

public class Email
{
    private readonly string _email;
    public Email(string email)
    {
        _email = email;
    }

    public string Value()
    {
        return _email;
    }
}
