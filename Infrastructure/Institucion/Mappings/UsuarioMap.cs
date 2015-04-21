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
            Map(x => x.RolUsuario, "RolUsuario_Id");
            Map(x => x.Activo, "Activo");
            HasMany(x => x.Dependencias)
                .Not.LazyLoad()
                .KeyColumn("Responsable_Usuario_Id")
                .Inverse()
                .Cascade.All();
            HasMany(x => x.DependenciasAsignadas)
                .Not.LazyLoad()
                .KeyColumn("Analista_Usuario_Id")
                .Inverse()
                .Cascade.All();
        }
    }
}