using Domain.Poa;
using FluentNHibernate.Mapping;

namespace Infrastructure.Poa.Mappings
{
    public class EjecucionActividadMap : ClassMap<EjecucionActividad>
    {
        public EjecucionActividadMap()
        {
            Table("EjecucionesActividad");
            Id(x => x.Id, "EjecucionMensual_Id");
            Map(x => x.Mes, "Mes");
            Map(x => x.Ejecucion, "Ejecucion");
            References(x => x.Indicador, "Indicador_Id");
            Map(x => x.Observaciones, "Observaciones");
            HasMany(x => x.ArchivosAdjuntos)
                .Table("EjecucionActividadAdjuntos")
                .Element("ArchivoURL")
                .KeyColumn("ArchivoAdjunto_Id")
                .Fetch.Select();
        }
    }
}