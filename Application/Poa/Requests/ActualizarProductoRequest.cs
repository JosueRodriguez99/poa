using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class ActualizarProductoRequest
    {
        public ProductoViewModel ProductoViewModel { get; set; }
        public int ProgramaEstrategicoId { get; set; }
    }
}