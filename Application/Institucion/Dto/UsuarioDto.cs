using Domain.Institucion;

namespace Application.Institucion.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public RolUsuario RolUsuario { get; set; }
        public bool Activo { get; set; }
    }
}