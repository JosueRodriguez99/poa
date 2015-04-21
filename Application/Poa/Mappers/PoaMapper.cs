using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Mappers
{
    public static class PoaMapper
    {
        public static Domain.Poa.Poa ToEntity(int dependenciaId)
        {
            var poa = new Domain.Poa.Poa();
            //poa.Id = dto.Id;
            //poa.Dependencia.Id = dto.DependenciaId;

            return poa;
        }

        public static PoaViewModel ToViewModel(this Domain.Poa.Poa poa)
        {
            var viewModel = new PoaViewModel();
            viewModel.Id = poa.Id;
            viewModel.Dependencia = poa.Dependencia.Nombre;
            viewModel.FechaEnvio = poa.FechaEnvio;
            viewModel.Version = poa.Version;
            viewModel.EstadoPoa = poa.Estado.ToString();
            return viewModel;
        }
    }
}
