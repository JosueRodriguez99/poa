using Application.Institucion.Dto;
using Application.Institucion.ViewModels;
using Domain.Institucion;

namespace Application.Institucion.Mappers
{
    public static class DependenciaMapper
    {
        public static Dependencia ToDependencia(this DependenciaDto dto)
        {
            var dependencia = new Dependencia();
            //Implementar
            return dependencia;
        }

        public static DependenciaViewModel ToViewModel(this Dependencia dependencia)
        {
            var viewModel = new DependenciaViewModel();
            viewModel.Id = dependencia.Id;
            viewModel.Nombre = dependencia.Nombre;
            if (dependencia.Reporta != null) viewModel.Reporta = dependencia.Reporta.Nombre;
            viewModel.Responsable = dependencia.Responsable.NombreUsuario;
            viewModel.Analista = dependencia.Analista.NombreUsuario;
            viewModel.Estado = (dependencia.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }
    }
}