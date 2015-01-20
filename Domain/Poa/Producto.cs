using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public class Producto : EntityBase<int>, IAggregateRoot, IAttribute
    {
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual ProgramaEstrategico ProgramaEstrategico { get; set; }
        public virtual IList<Actividad> Actividades { get; set; }
        public virtual bool Activo { get; set; }

        public Producto()
        {
            Actividades = new List<Actividad>();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}