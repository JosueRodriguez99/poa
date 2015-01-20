using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class AgregarActividadRequest
    {
        public ActividadViewModel ActividadViewModel { get; set; }
        public int PoaId { get; set; }
    }
}