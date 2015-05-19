using System.ComponentModel.DataAnnotations;

namespace Application.Poa.Dto
{
    public class NuevaActividadDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción")]
        public string Descripcion { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int UnidadDeMedidaId { get; set; }

        [Required]
        public string Indicador { get; set; }

        [Required]
        public string Enero { get; set; }

        [Required]
        public string Febrero { get; set; }

        [Required]
        public string Marzo { get; set; }

        [Required]
        public string Abril { get; set; }

        [Required]
        public string Mayo { get; set; }

        [Required]
        public string Junio { get; set; }

        [Required]
        public string Julio { get; set; }

        [Required]
        public string Agosto { get; set; }

        [Required]
        public string Septiembre { get; set; }

        [Required]
        public string Octubre { get; set; }

        [Required]
        public string Noviembre { get; set; }

        [Required]
        public string Diciembre { get; set; }

        [Required]
        public string MedioDeVerificacion { get; set; }

        [Required]
        public string ResponsableId { get; set; }

        [Required]
        public int PoaId { get; set; }
    }
}
