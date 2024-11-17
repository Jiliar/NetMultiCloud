namespace Usuarios.Domain.ValueObjects.Users;

public record NickName
{
    public string Value { get; init; }

    private NickName(string value)
    {
        Value = value;
    }

    public static NickName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("The user name cannot be empty.", nameof(value));
        }
        return new NickName(value);
    }
}
