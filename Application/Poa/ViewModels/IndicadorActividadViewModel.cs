using System.Collections.Generic;

namespace Application.Poa.ViewModels
{
    public class IndicadorActividadViewModel
    {
        public int IndicadorActividadId { get; set; }
        public string Descripcion { get; set; }
        public double Meta { get; set; }
        public string MedioVerificacion { get; set; }
        public IList<ProgramacionActividadViewModel> ProgramacionMensual { get; set; }
        public IList<EjecucionActividadViewModel> EjecucionMensual { get; set; }
        public bool Suma { get; set; }

        public IndicadorActividadViewModel()
        {
            ProgramacionMensual = new List<ProgramacionActividadViewModel>();
            EjecucionMensual = new List<EjecucionActividadViewModel>();
        }
    }
}