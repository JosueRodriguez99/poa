using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ActividadMap : ClassMap<Actividad>
    {
        public ActividadMap()
        {
            Table("Actividades");
            Id(x => x.Id, "Actividad_Id");
            Map(x => x.Descripcion, "Descripcion");
            References(x => x.Producto, "Producto_Id");
            References(x => x.Responsable, "Responsable");
            References(x => x.Poa, "Poa_Id");
            HasMany(x => x.Tareas).Inverse().Cascade.All();
            HasMany(x => x.Indicadores).Inverse().Cascade.All();
        }
    }
}