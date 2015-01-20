using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class IndicadorActividadMap : ClassMap<IndicadorActividad>
    {
        public IndicadorActividadMap()
        {
            Table("IndicadoresActividad");
            Id(x => x.Id, "IndicadorActividad_Id");
            Map(x => x.Descripcion, "Descripcion");
            Map(x => x.UnidadMedida, "UnidadMedida_Id").CustomType<int>();
            Map(x => x.Meta, "Meta");
            Map(x => x.MedioVerificacion, "MedioVerificacion");
            HasMany(x => x.ProgramacionMensual).Inverse().Cascade.All();
            HasMany(x => x.EjecucionMensual).Inverse().Cascade.All();
            References(x => x.Actividad, "Actividad_Id");
            Map(x => x.Suma, "Suma");
            HasMany(x => x.IndicadoresQueLoComponen).Inverse().Cascade.All();
        }
    }
}