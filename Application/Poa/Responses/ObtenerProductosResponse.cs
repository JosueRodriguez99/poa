using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerProductosResponse
    {
        public List<ProductoViewModel> Productos { get; set; }

        public ObtenerProductosResponse()
        {
            Productos = new List<ProductoViewModel>();
        }
    }
}