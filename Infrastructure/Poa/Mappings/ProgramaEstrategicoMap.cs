using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ProgramaEstrategicoMap : ClassMap<ProgramaEstrategico>
    {
        public ProgramaEstrategicoMap()
        {
            Table("ProgramasEstrategicos");
            Id(x => x.Id, "ProgramaEstrategico_Id");
            Map(x => x.Nombre, "Nombre");
            Map(x => x.Descripcion, "Descripcion").Length(750);
            Map(x => x.Activo, "Activo");
            HasMany(x => x.Productos).Inverse().Cascade.All();
            HasMany(x => x.Presupuestos).Inverse().Cascade.All();
        }
    }
}