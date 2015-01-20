using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class PresupuestoMap : ClassMap<Presupuesto>
    {
        public PresupuestoMap()
        {
            Table("Presupuestos");
            Id(x => x.Id, "Presupuesto_Id");
            References(x => x.ConceptoPresupuesto, "ConceptoPresupuesto_Id");
            Map(x => x.Monto, "Monto");
            References(x => x.ProgramaEstrategico, "ProgramaEstrategico_Id");
            References(x => x.Poa, "Poa_Id");
        }
    }
}