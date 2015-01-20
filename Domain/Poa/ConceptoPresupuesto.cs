using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public class ConceptoPresupuesto : EntityBase<int>, IAttribute, IAggregateRoot
    {
        public virtual int Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual IList<Presupuesto> PresupuestosConEsteConcepto { get; set; }

        public ConceptoPresupuesto()
        {
            PresupuestosConEsteConcepto = new List<Presupuesto>();
        }

        public virtual void AgregarPresupuesto(Presupuesto presupuesto)
        {
            if (presupuesto == null) throw new ArgumentNullException("presupuesto");
            presupuesto.ConceptoPresupuesto = this;
            PresupuestosConEsteConcepto.Add(presupuesto);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}