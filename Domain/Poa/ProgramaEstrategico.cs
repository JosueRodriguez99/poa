using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public class ProgramaEstrategico : EntityBase<int>, IAggregateRoot, IAttribute
    {
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual IList<Producto> Productos { get; set; }
        public virtual IList<Presupuesto> Presupuestos { get; set; }
        public virtual bool Activo { get; set; }

        public ProgramaEstrategico()
        {
            Productos = new List<Producto>();
            Presupuestos = new List<Presupuesto>();
        }

        public virtual void AgregarProducto(Producto producto)
        {
            if (producto == null) throw new ArgumentNullException("producto");
            producto.ProgramaEstrategico = this;
            Productos.Add(producto);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}