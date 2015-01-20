using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class TareaMap : ClassMap<Tarea>
    {
        public TareaMap()
        {
            Table("Tareas");
            Id(x => x.Id, "Tarea_Id");
            Map(x => x.Descripcion, "Descripcion");
            References(x => x.Actividad, "Actividad_Id");
            HasMany(x => x.Indicadores).Inverse().Cascade.All();
            //References(x => x.Responsable, "Dependencia_Id");
        }
    }
}