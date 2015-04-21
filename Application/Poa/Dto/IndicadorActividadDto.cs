using System.Collections.Generic;

namespace Application.Poa.Dto
{
    public class IndicadorActividadDto
    {
        public int Id { get; set; }
        public int Actividad { get; set; }
        public bool Suma { get; set; }
        public List<IndicadorTareaDto> Indicadores { get; set; }
        public List<ProgramacionActividadDto> ProgramacionMensual { get; set; }
        public List<EjecucionActividadDto> EjecucionMensual { get; set; }
    }
}
