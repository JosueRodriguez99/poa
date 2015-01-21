using Application.Poa.ViewModels;

namespace Application.Poa.Mappers
{
    public static class PoaExtensionMethods
    {
        public static PoaViewModel ToViewModel(this Domain.Poa.Poa poa)
        {
            var viewModel = new PoaViewModel();
            viewModel.Version = poa.Version;
            viewModel.Dependencia = poa.Dependencia.Nombre;
            viewModel.EstadoPoa = poa.Estado.ToString();
            return viewModel;
        }

        public static Domain.Poa.Poa ToEntity(this PoaViewModel viewModel)
        {
            var poa = new Domain.Poa.Poa();
            poa.Id = viewModel.Id;
            poa.FechaEnvio = viewModel.FechaEnvio;
            poa.Version = viewModel.Version;
            return poa;
        }
    }
}