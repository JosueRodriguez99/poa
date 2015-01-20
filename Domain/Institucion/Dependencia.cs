using System.Collections.Generic;
using Domain.Common;
using System;

namespace Domain.Institucion
{
    public class Dependencia : EntityBase<int>, IAggregateRoot
    {
        public virtual string Nombre { get; set; }
        public virtual Usuario Responsable { get; set; }
        public virtual Dependencia Reporta { get; set; }
        public virtual Usuario Analista { get; set; }
        public virtual bool Activo { get; set; }
        public virtual IList<Poa.Poa> Poas { get; set; }

        public Dependencia()
        {
            Poas = new List<Poa.Poa>();    
        }

        public virtual void AgregarPoa(Poa.Poa poa)
        {
            if (poa == null) throw new ArgumentNullException("poa");
            poa.Dependencia = this;
            Poas.Add(poa);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}