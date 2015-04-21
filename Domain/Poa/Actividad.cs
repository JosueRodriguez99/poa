using Domain.Common;
using System;
using System.Collections.Generic;
using Domain.Institucion;

namespace Domain.Poa
{
    public class Actividad : EntityBase<int>, IAttribute, IAggregateRoot
    {
        public virtual string Descripcion { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Poa Poa { get; set; }
        public virtual IList<Tarea> Tareas { get; set; }
        public virtual IList<IndicadorActividad> Indicadores { get; set; }
        public virtual Dependencia Responsable { get; set; }

        public Actividad()
        {
            Indicadores = new List<IndicadorActividad>();
            Tareas = new List<Tarea>();
        }

        public virtual void AgregarIndicador(IndicadorActividad indicador)
        {
            if (indicador == null) throw new ArgumentNullException("indicador");
            indicador.Actividad = this;
            Indicadores.Add(indicador);
        }

        public virtual void AgregarTarea(Tarea tarea)
        {
            if (tarea == null) throw new ArgumentNullException("tarea");
            tarea.Actividad = this;
            Tareas.Add(tarea);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}