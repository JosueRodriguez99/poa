using Domain.Institucion;
using FluentNHibernate.Mapping;

namespace Infrastructure.Institucion.Mappings
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("Usuarios");
            Id(x => x.Id, "Usuario_Id");
            Map(x => x.NombreUsuario, "NombreUsuario");
            Map(x => x.RolUsuario, "RolUsuario_Id").CustomType<int>();
            Map(x => x.Activo, "Activo");
            References(x => x.Dependencia, "Dependencia_Id").Not.LazyLoad();
            HasMany(x => x.DependenciasAsignadas).Inverse().Cascade.All();
        }
    }
}