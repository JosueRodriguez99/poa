using System.Collections.Generic;

namespace Application.Poa.Dto
{
    public class PoaDto
    {
        public List<ActividadDto> Actividades { get; set; }
        public List<PresupuestoDto> Presupuestos { get; set; }
        public int DependenciaId { get; set; }
    }
}
