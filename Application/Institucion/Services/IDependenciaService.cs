using Application.Institucion.Requests;
using Application.Institucion.Responses;

namespace Application.Institucion.Services
{
    public interface IDependenciaService
    {
        void CrearDependencia(CrearDependenciaRequest request);
        void ActualizarDependencia(ActualizarDependenciaRequest request);
        void EliminarDependencia(EliminarDependenciaRequest request);
        ObtenerDependenciasResponse ObtenerDependencias();
        ObtenerDependenciasResponse ObtenerDependenciasActivas();
    }
}