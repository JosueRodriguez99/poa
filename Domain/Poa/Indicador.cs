using Domain.Common;

namespace Domain.Poa
{
    public abstract class Indicador : EntityBase<int>, IAttribute
    {
        public virtual string Descripcion { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
        public virtual double Meta { get; set; }
        public virtual string MedioVerificacion { get; set; }
    }
}