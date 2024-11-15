namespace Usuarios.Domain.Usuarios;
    public class Usuario
    {
        public string? NombreUsuario {get; set;}   
        public string? NombresPersona {get; set;}
        public string? ApellidoPaterno {get; set;}
        public string? ApellidoMaterno {get; set;}
        public string? Password {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public Direccion? Direccion{get; set;}
        public int Estado {get; set;}
    }