using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerProgramasEstrategicosResponse
    {
        public List<ProgramaEstrategicoViewModel> ProgramasEstrategicos { get; set; }

        public ObtenerProgramasEstrategicosResponse()
        {
            ProgramasEstrategicos = new List<ProgramaEstrategicoViewModel>();
        }
    }
}