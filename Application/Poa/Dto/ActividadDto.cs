using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class ActividadDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        public string Descripcion { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public string ResponsableId { get; set; }

        [Required]
        public int PoaId { get; set; }
    }
}
