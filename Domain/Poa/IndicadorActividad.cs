using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public class IndicadorActividad : Indicador
    {
        public virtual Actividad Actividad { get; set; }
        public virtual bool Suma { get; set; }
        public virtual IList<IndicadorTarea> IndicadoresQueLoComponen { get; set; }
        public virtual IList<ProgramacionActividad> ProgramacionMensual { get; set; }
        public virtual IList<EjecucionActividad> EjecucionMensual { get; set; }

        public IndicadorActividad()
        {
            ProgramacionMensual = new List<ProgramacionActividad>();
            EjecucionMensual = new List<EjecucionActividad>();
        }

        public virtual void AgregarProgramacionMensual(ProgramacionActividad programacion)
        {
            if (programacion == null) throw new ArgumentNullException("programacion");
            programacion.Indicador = this;
            ProgramacionMensual.Add(programacion);
        }

        public virtual void AgregarEjecucionMensual(EjecucionActividad ejecucion)
        {
            if (ejecucion == null) throw new ArgumentNullException("ejecucion");
            ejecucion.Indicador = this;
            EjecucionMensual.Add(ejecucion);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}