using Domain.Institucion;
using FluentNHibernate.Mapping;

namespace Infrastructure.Institucion.Mappings
{
    public class DependenciaMap : ClassMap<Dependencia>
    {
        public DependenciaMap()
        {
            Table("Dependencias");
            Id(x => x.Id, "Dependencia_Id");
            Map(x => x.Nombre, "Nombre");
            Map(x => x.Activo, "Activo");
            References(x => x.Responsable, "Responsable_Usuario_Id").Not.LazyLoad();
            References(x => x.Reporta, "Reporta_Dependencia_Id").Not.LazyLoad();
            References(x => x.Analista, "Analista_Usuario_Id").Not.LazyLoad();
        }
    }
}