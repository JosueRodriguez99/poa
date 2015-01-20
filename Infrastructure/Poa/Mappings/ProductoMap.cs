using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ProductoMap : ClassMap<Producto>
    {
        public ProductoMap()
        {
            Table("Productos");
            Id(x => x.Id, "Producto_Id");
            Map(x => x.Codigo, "Codigo");
            Map(x => x.Descripcion, "Descripcion");
            References(x => x.ProgramaEstrategico, "ProgramaEstrategico_Id").Not.LazyLoad();
            Map(x => x.Activo, "Activo");
            HasMany(x => x.Actividades).Inverse().Cascade.All();
        }
    }
}