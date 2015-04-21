using System.Collections.Generic;

namespace Application.Poa.Dto
{
    public class IndicadorTareaDto
    {
        public int TareaId { get; set; }
        public int IndicadorAlQueSumaId { get; set; }
        public List<ProgramacionTareaDto> ProgramacionMensual { get; set; } 
        public List<EjecucionTareaDto> EjecucionMensual { get; set; } 
    }
}
