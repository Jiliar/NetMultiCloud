namespace Usuarios.Domain.ValueObjects.Users;

public record Address(
    string? Continent,
    string? Country,
    string? State,
    string? Province,
    string? District,
    string? Street
);
