namespace Usuarios.Domain.Entities.Errors;
using Usuarios.Domain.Abstractions;
public static class RoleError
{
    public static Error NotFound = new("Role.NotFound", "The role was not found");
}
