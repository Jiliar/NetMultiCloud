namespace Usuarios.Domain.Abstractions;

    public record Error(
        string Code,
        string Name
    )
    {
        public static Error None = new Error(string.Empty, string.Empty);
         public static Error NullValue = new Error("Error.NullValue", " El valor no puede ser nulo.");
    }