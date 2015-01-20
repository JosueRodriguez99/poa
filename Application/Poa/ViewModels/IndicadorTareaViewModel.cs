using System.Collections.Generic;

namespace Application.Poa.ViewModels
{
    public class IndicadorTareaViewModel
    {
        public int IndicadorTareaId { get; set; }
        public UnidadMedidaViewModel UnidadMedida { get; set; }
        public double Meta { get; set; }
        public string MedioVerificacion { get; set; }
        public IList<ProgramacionTareaViewModel> ProgramacionTarea { get; set; }
        public IList<EjecucionTareaViewModel> EjecucionTarea { get; set; }
        public int IndicadorAlQueSuma { get; set; }
    }
}