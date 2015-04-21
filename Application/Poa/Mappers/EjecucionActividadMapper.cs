using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    class EjecucionActividadMapper
    {
        public static EjecucionActividad ToEntity( EjecucionActividadDto dto)
        {
            var ejecucionActividad = new EjecucionActividad();
            ejecucionActividad.Indicador.Id = dto.IndicadorActividadId;

            return ejecucionActividad;
        }

        public static EjecucionActividadViewModel ToViewModel( EjecucionActividad ejecucionActividad)
        {
            var viewModel = new EjecucionActividadViewModel();
            viewModel.IndicadorActividadId = ejecucionActividad.Id;

            return viewModel;
        }
    }
}
