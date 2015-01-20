using Domain.Common;
using System;
using System.Collections.Generic;
using Domain.Institucion;

namespace Domain.Poa
{
    public class Tarea : EntityBase<int>, IAttribute 
    {
        public virtual string Descripcion { get; set; }
        public virtual Actividad Actividad { get; set; }
        public virtual IList<IndicadorTarea> Indicadores { get; set; }
        public virtual Dependencia Responsable { get; set; }

        public virtual void AgregarIndicador(IndicadorTarea indicador)
        {
            indicador.Tarea = this;
            Indicadores.Add(indicador);
        }

        public Tarea()
        {
            Indicadores = new List<IndicadorTarea>();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}