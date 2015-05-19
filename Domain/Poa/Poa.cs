using System;
using System.Collections.Generic;
using Domain.Common;
using Domain.Institucion;

namespace Domain.Poa
{
    public class Poa : EntityBase<int>, IAggregateRoot
    {
        public virtual IList<Actividad> Actividades { get; set; }
        public virtual IList<Presupuesto> Presupuestos { get; set; }
        public virtual DateTime FechaEnvio { get; set; }
        public virtual int Version { get; set; }
        public virtual Dependencia Dependencia { get; set; }
        public virtual EstadoPoa Estado { get; set; }

        public Poa()
        {
            Actividades = new List<Actividad>();
            Presupuestos = new List<Presupuesto>();
            FechaEnvio = DateTime.Now;
        }

        public virtual void AgregarActividad(Actividad actividad)
        {
            if (actividad == null) throw new ArgumentNullException("actividad");
            actividad.Poa = this;
            Actividades.Add(actividad);
        }

        public virtual void AgregarPresupuesto(Presupuesto presupuesto)
        {
            if (presupuesto == null) throw new ArgumentNullException("presupuesto");
            presupuesto.Poa = this;
            Presupuestos.Add(presupuesto);
        }
        
        public virtual void Enviar()
        {
            FechaEnvio = DateTime.Now;
            Estado = EstadoPoa.Enviado;
        }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}