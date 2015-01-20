using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ConceptoPresupuestoMap : ClassMap<ConceptoPresupuesto>
    {
        public ConceptoPresupuestoMap()
        {
            Table("ConceptosPresupuesto");
            Id(x => x.Id);
            Map(x => x.Codigo, "Codigo");
            Map(x => x.Descripcion, "Descripcion");
        }
    }
}