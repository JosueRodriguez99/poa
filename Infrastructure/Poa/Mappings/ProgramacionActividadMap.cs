using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ProgramacionActividadMap : ClassMap<ProgramacionActividad>
    {
        public ProgramacionActividadMap()
        {
            Table("ProgramacionesActividad");
            Id(x => x.Id, "ProgramacionActividad_Id");
            Map(x => x.Mes, "Mes");
            Map(x => x.Programacion, "Programacion");
            References(X => X.Indicador, "IndicadorActividad_Id");
        }
    }
}