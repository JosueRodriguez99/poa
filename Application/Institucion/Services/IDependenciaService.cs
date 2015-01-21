using System.Collections.Generic;
using Application.Institucion.Dto;
using Application.Institucion.ViewModels;

namespace Application.Institucion.Services
{
    public interface IDependenciaService
    {
        void CrearDependencia(DependenciaDto request);
        void ActualizarDependencia(DependenciaDto request);
        void EliminarDependencia(int id);
        DependenciaViewModel ObtenerPorId(int id);
        List<DependenciaViewModel> ObtenerDependencias();
        List<DependenciaViewModel> ObtenerDependenciasActivas();
    }
}