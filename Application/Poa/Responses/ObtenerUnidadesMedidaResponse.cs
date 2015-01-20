using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerUnidadesMedidaResponse
    {
        public List<UnidadMedidaViewModel> UnidadesMedida { get; set; }

        public ObtenerUnidadesMedidaResponse()
        {
            UnidadesMedida = new List<UnidadMedidaViewModel>();
        }
    }
}