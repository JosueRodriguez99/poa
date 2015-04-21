using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public class IndicadorTarea : Indicador
    {
        public virtual Tarea Tarea { get; set; }
        public virtual IndicadorActividad IndicadorAlQueSuma { get; set; }
        public virtual IList<ProgramacionTarea> ProgramacionMensual { get; set; }
        public virtual IList<EjecucionTarea> EjecucionMensual { get; set; }

        public IndicadorTarea()
        {
            ProgramacionMensual = new List<ProgramacionTarea>();
            EjecucionMensual = new List<EjecucionTarea>();
        }

        public virtual void AgregarProgramacion(ProgramacionTarea programacion)
        {
            if (programacion == null) throw new ArgumentNullException("programacion");
            programacion.Indicador = this;
            ProgramacionMensual.Add(programacion);
        }

        public virtual void AgregarEjecucion(EjecucionTarea ejecucion)
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