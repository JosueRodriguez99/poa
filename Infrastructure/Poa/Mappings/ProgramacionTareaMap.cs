using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class ProgramacionTareaMap : ClassMap<ProgramacionTarea>
    {
        public ProgramacionTareaMap()
        {
            Table("ProgramacionesTarea");
            Id(x => x.Id, "ProgramacionTarea_Id");
            Map(x => x.Mes, "Mes");
            Map(x => x.Programacion, "Programacion");
            References(x => x.Indicador, "IndicadorTarea_Id");
        }
    }
}