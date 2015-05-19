using Application.Poa.ViewModels;
using Application.Poa.Dto;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    static class IndicadorTareaMapper
    {
        public static IndicadorTarea ToEntity(this IndicadorTareaDto dto)
        {
            var indicadorTarea = new IndicadorTarea();
            //indicadorTarea.Id = dto.Id;
            //indicadorTarea.Tarea = dto.TareaId;
            //indicadorTarea.IndicadorAlQueSuma = dto.IndicadorAlQueSumaId;
            //indicadorTarea.ProgramacionMensual = dto.ProgramacionMensual;
            //indicadorTarea.EjecucionMensual = dto.EjecucionMensual;
            return indicadorTarea;
        }

        public static IndicadorTareaViewModel ToViewModel(this IndicadorTarea indicadorTarea)
        {
            var viewModel = new IndicadorTareaViewModel();
            viewModel.IndicadorTareaId = indicadorTarea.Tarea.Id;

            return viewModel;
        }
    }
}
