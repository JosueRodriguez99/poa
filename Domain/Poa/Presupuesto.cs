using Domain.Common;
using System;

namespace Domain.Poa
{
    public class Presupuesto : EntityBase<int>
    {
        public virtual ConceptoPresupuesto ConceptoPresupuesto { get; set; }
        public virtual double Monto { get; set; }
        public virtual ProgramaEstrategico ProgramaEstrategico { get; set; }
        public virtual Poa Poa { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}