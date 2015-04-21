using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class TareaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        public string Descripcion { get; set; }

        [Required]
        public int ActividadId { get; set; }

        [Required]
        public int DependenciaId { get; set; }
    }
}
