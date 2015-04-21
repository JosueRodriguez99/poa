using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Institucion
{
    public class Usuario : EntityBase<int>, IAggregateRoot
    {
        public virtual string NombreUsuario { get; set; }
        public virtual RolUsuario RolUsuario { get; set; }
        public virtual bool Activo { get; set; }
        public virtual IList<Dependencia> Dependencias { get; set; }
        public virtual IList<Dependencia> DependenciasAsignadas { get; set; }
        public virtual Dependencia DependenciaEnlace{ get; set; }

        public Usuario()
        {
            Dependencias = new List<Dependencia>();
            DependenciasAsignadas = new List<Dependencia>();
        }

        public virtual void AsignarDependenciaParaAnalizar(Dependencia dependencia)
        {
            if (dependencia == null) throw new ArgumentNullException("dependencia");
            if(RolUsuario != RolUsuario.Analista) throw new Exception("Usuario no es analista");

            dependencia.Analista = this;
            DependenciasAsignadas.Add(dependencia);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}