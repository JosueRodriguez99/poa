using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class ActualizarProgramaEstrategicoRequest
    {
        public int ProgramaEstrategicoId { get; set; }
        public ProgramaEstrategicoViewModel ProgramaEstrategicoViewModel { get; set; }
    }
}