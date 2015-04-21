using Application.Poa.ViewModels;
using Application.Poa.Dto;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    static class IndicadorActividadMapper
    {
        public static IndicadorActividad ToEntity(this IndicadorActividadDto dto)
        {
            var indicadorActividad = new IndicadorActividad();
            indicadorActividad.Id = dto.Id;
            //indicadorActividad.Actividad = dto.Actividad;
            indicadorActividad.Suma = dto.Suma;
            //indicadorActividad.IndicadoresQueLoComponen = dto.IndicadoresQueLoComponen;
            //indicadorActividad.ProgramacionMensual = dto.ProgramacionMensual;
            //indicadorActividad.EjecucionMensual = dto.EjecucionMensual;
            return indicadorActividad;
        }

        public static IndicadorActividadViewModel ToViewModel(this IndicadorActividad indicadorActividad)
        {
            var viewModel = new IndicadorActividadViewModel();
            viewModel.IndicadorActividadId = indicadorActividad.Actividad.Id;

            return viewModel;
        }
    }
}
