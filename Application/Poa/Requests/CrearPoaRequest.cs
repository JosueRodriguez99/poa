using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class CrearPoaRequest
    {
        public PoaViewModel PoaViewModel { get; set; }
        public int DependenciaId { get; set; }
    }
}