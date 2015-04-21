using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    static class TareaMapper
    {
        public static TareaViewModel ToViewModel(this Tarea tarea)
        {
            var viewModel = new TareaViewModel();
            viewModel.Id = tarea.Id;
            viewModel.Descripcion = tarea.Descripcion;
            viewModel.Actividad = tarea.Actividad.Descripcion;
            viewModel.Responsable = tarea.Responsable.Nombre;

            return viewModel;
        }

        public static Tarea ToEntity(this TareaDto dto)
        {
            var tarea = new Tarea();
            tarea.Id = dto.Id;
            tarea.Descripcion = dto.Descripcion;

            return tarea;
        }
    }
}
