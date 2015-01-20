using Domain.Common;
using System;

namespace Domain.Poa
{
    public abstract class ProgramacionMensual : EntityBase<int>
    {
        public virtual int Mes { get; set; }
        public virtual double Programacion { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}