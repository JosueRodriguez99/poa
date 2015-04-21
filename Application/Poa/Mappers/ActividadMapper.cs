using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class ActividadMapper
    {
         public static Actividad ToEntity(this ActividadDto dto)
        {
            var actividad = new Actividad();
             actividad.Id = dto.Id;
             actividad.Descripcion = dto.Descripcion;
         
            return actividad;
        }

        public static ActividadViewModel ToViewModel(this Actividad actividad)
        {
            var viewModel = new ActividadViewModel();
            viewModel.Id = actividad.Id;
            viewModel.Descripcion = actividad.Descripcion;
            viewModel.Producto = actividad.Producto.Descripcion;
            viewModel.Responsable = actividad.Responsable.Nombre;
            viewModel.Poa = actividad.Poa.Id;

            return viewModel;
        }
    }
}
