using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class CrearProductoRequest
    {
        public ProductoViewModel ProductoViewModel { get; set; }
        public int ProgramaEstrategicoId { get; set; }
    }
}