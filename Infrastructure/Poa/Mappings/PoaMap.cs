using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class PoaMap : ClassMap<Domain.Poa.Poa>
    {
        public PoaMap()
        {
            Table("Poas");
            Id(x => x.Id, "Poa_Id");
            Map(x => x.FechaEnvio, "FechaEnvio");
            Map(x => x.Version, "Version");
            Map(x => x.Estado, "EstadoPoa_Id").CustomType<int>();
            References(x => x.Dependencia, "Dependencia_Id").Not.LazyLoad();
            HasMany(x => x.Actividades).Inverse().Cascade.All();
            HasMany(x => x.Presupuestos).Inverse().Cascade.All();
        }
    }
}