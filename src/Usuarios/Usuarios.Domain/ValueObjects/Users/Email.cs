namespace Usuarios.Domain.ValueObjects.Users;

using System.Text.RegularExpressions;
using Usuarios.Domain.Abstractions;

public record Email
{
    public string Value { get; init; }

    private Email(string value)
    {
        Value = value;
    }

    public static implicit operator string(Email d) => d.Value;

    public static Result<Email> Create(string value)
    {
        if (IsValidEmail(value))
        {
            return new Email(value);
        }
        throw new InvalidOperationException("The email address is not valid");
    }

    private static bool IsValidEmail(string email)
    {
        const string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        var isCorrect = Regex.Match(email, emailRegex).Success;

        return isCorrect;
    }
}
