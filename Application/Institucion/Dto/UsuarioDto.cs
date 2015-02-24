using System.ComponentModel.DataAnnotations;

namespace Application.Institucion.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un nombre de usuario válido.")]
        public string NombreUsuario { get; set; }

        [Required]
        public int RolUsuario { get; set; }

        public bool Activo { get; set; }
    }
}