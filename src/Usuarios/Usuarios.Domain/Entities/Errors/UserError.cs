namespace Usuarios.Domain.Entities.Errors;
using Usuarios.Domain.Abstractions;

public class UserError
{
    public static Error AlreadyActive = new(
        "User.AlreadyActive",
        "The user is already active"
    );

    public static Error AlreadyInactive = new(
        "User.AlreadyInactive",
        "The user is already inactive"
    );
}
