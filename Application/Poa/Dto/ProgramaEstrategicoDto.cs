using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class ProgramaEstrategicoDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(35)]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}