using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerPoaPorDependenciaResponse
    {
        public List<PoaViewModel> Poas { get; set; }

        public ObtenerPoaPorDependenciaResponse()
        {
            Poas = new List<PoaViewModel>();
        }
    }
}