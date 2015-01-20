using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.MapperExtensionMethods
{
    public static class ActividadExtensionMethods
    {
        public static ActividadViewModel ToViewModel(this Actividad actividad)
        {
            var viewModel = new ActividadViewModel();
            viewModel.Id = actividad.Id;
            viewModel.Descripcion = actividad.Descripcion;
            return viewModel;
        }

        public static Actividad ToEntity(this ActividadViewModel viewModel)
        {
            var actividad = new Actividad();
            actividad.Id = viewModel.Id;
            actividad.Descripcion = viewModel.Descripcion;
            return actividad;
        }
    }
}