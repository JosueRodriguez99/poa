using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    class EjecucionTareaMapper
    {
        public static EjecucionTarea ToEntity(EjecucionTarea dto)
        {
            var ejecucionTarea = new EjecucionTarea();
            ejecucionTarea.Indicador = dto.Indicador;

            return ejecucionTarea;
        }

        public static EjecucionTareaViewModel ToViewModel(EjecucionTarea ejecucionTarea)
        {
            var viewModel = new EjecucionTareaViewModel();
            viewModel.IndicadorTareaId = ejecucionTarea.Indicador.Id;

            return viewModel;
        }
    }
}
