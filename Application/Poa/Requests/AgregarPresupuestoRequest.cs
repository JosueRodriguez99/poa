using Application.Poa.ViewModels;

namespace Application.Poa.Requests
{
    public class AgregarPresupuestoRequest
    {
        public PresupuestoViewModel Presupuesto { get; set; }
        public int PoaId { get; set; }
        public int ConceptoPresupuestoId { get; set; }
    }
}