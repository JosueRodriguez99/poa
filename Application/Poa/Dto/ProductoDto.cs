using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class ProductoDto
    {
        public int Id { get; set; }

        [StringLength(10), Required(ErrorMessage = "Por favor ingrese el código del producto")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        public string Descripcion { get; set; }

        [Required]
        public int ProgramaEstrategicoId { get; set; }

        public bool Activo { get; set; }
    }
}