namespace Usuarios.Domain.Usuarios;

    public record Direccion(
         string? Continente,
         string? Pais,
         string? Departamento,
         string? Provincia,
         string? Distrito,
         string? Calle
    );