using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class NuevaActividadMapper
    {
        public static Actividad ToEntity(this NuevaActividadDto dto)
        {
            var nuevaActividad = new Actividad();
            nuevaActividad.Id = dto.Id;
            nuevaActividad.Descripcion = dto.Descripcion;

            return nuevaActividad;
        }

        public static NuevaActividadViewModel ToViewModel(this Actividad actividad)
        {
            var viewModel = new NuevaActividadViewModel();
            viewModel.Id = actividad.Id;
            viewModel.Descripcion = actividad.Descripcion;
            viewModel.Producto = actividad.Producto.Descripcion;
            viewModel.Responsable = actividad.Responsable.Nombre;
            viewModel.Poa = actividad.Poa.Id;

            return viewModel;
        }
    }
}
