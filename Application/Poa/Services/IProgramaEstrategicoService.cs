using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    public interface IProgramaEstrategicoService
    {
        void CrearProgramaEstrategico(ProgramaEstrategicoDto request);
        void ActualizarProgramaEstrategico(ProgramaEstrategicoDto request);
        void EliminarProgramaEstrategico(int id );
        ProgramaEstrategicoViewModel ObtenerProgramaEstrategicoPorId(int id);
        List<ProgramaEstrategicoViewModel> ObtenerProgramasEstrategicos();
        List<ProgramaEstrategicoViewModel> ObtenerProgramasEstrategicosActivos();
    }
}