using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerTodosLosPoaResponse
    {
        public List<PoaViewModel> Poas { get; set; }

        public ObtenerTodosLosPoaResponse()
        {
            Poas = new List<PoaViewModel>();
        }
    }
}