using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class ProgramaEstrategicoDto
    {
        public int Id { get; set; }

        [StringLength(100), Required(ErrorMessage = "Por favor ingrese un nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción.")]
        public string Descripcion { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}