using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Poa
{
    public abstract class EjecucionMensual : EntityBase<int>
    {
        public virtual int Mes { get; set; }
        public virtual double Ejecucion { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual IList<string> ArchivosAdjuntos { get; set; }

        public EjecucionMensual()
        {
            ArchivosAdjuntos = new List<string>();
        }
        
        public virtual void AgregarArchivo(string archivoPath)
        {
            if (archivoPath == null) throw new ArgumentNullException("archivoPath");
            ArchivosAdjuntos.Add(archivoPath);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}