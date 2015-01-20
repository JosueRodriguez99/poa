using Application.Poa.Requests;
using Application.Poa.Responses;

namespace Application.Poa.Services
{
    public interface IProgramaEstrategicoService
    {
        void CrearProgramaEstrategico(CrearProgramaEstrategicoRequest request);
        void ActualizarProgramaEstrategico(ActualizarProgramaEstrategicoRequest request);
        void EliminarProgramaEstrategico(EliminarProgramaEstrategicoRequest request);
        ObtenerProgramaEstrategicoPorIdResponse ObtenerProgramaEstrategicoPorId(int id);
        ObtenerProgramasEstrategicosResponse ObtenerProgramasEstrategicos();
        ObtenerProgramasEstrategicosResponse ObtenerProgramasEstrategicosActivos();
    }
}