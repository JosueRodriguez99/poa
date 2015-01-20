using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class IndicadorTareaMap : ClassMap<IndicadorTarea>
    {
        public IndicadorTareaMap()
        {
            Table("IndicadoresTarea");
            Id(x => x.Id, "IndicadorTarea_Id");
            Map(x => x.Descripcion, "Descripcion");
            Map(x => x.UnidadMedida, "UnidadMedida_Id").CustomType<int>();
            Map(x => x.Meta, "Meta");
            Map(x => x.MedioVerificacion, "MedioVerificacion");
            HasMany(x => x.ProgramacionMensual).Inverse().Cascade.All();
            HasMany(x => x.EjecucionMensual).Inverse().Cascade.All();
            References(x => x.IndicadorAlQueSuma, "IndicadorTarea_Id");
        }
    }
}