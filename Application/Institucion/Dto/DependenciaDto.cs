using System.ComponentModel.DataAnnotations;

namespace Application.Institucion.Dto
{
    public class DependenciaDto
    {
        public int Id { get; set; }
        [StringLength(30), Required(ErrorMessage = "Ingrese una dependencia.")]
        public string Nombre { get; set; }

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public int AnalistaId { get; set; }

        public int ReportaId { get; set; }
        public bool Activo { get; set; }
    }
}