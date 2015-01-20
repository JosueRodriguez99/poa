using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class EjecucionTareaMap : ClassMap<EjecucionTarea>
    {
        public EjecucionTareaMap()
        {
            Table("EjecucionesTarea");
            Id(x => x.Id, "EjecucionTarea_Id");
            Map(x => x.Mes, "Mes");
            Map(x => x.Ejecucion, "Ejecucion");
            References(x => x.Indicador, "Indicador_Id");
            Map(x => x.Observaciones, "Observaciones");
            HasMany(x => x.ArchivosAdjuntos)
                .Table("EjecucionTareaAdjuntos")
                .Element("ArchivoURL")
                .KeyColumn("ArchivoAdjunto_Id")
                .Fetch.Select();
        }
    }
}