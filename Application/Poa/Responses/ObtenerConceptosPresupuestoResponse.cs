using Application.Poa.ViewModels;
using System.Collections.Generic;

namespace Application.Poa.Responses
{
    public class ObtenerConceptosPresupuestoResponse
    {
        public List<ConceptoPresupuestoViewModel> ConceptosPresupuesto { get; set; }

        public ObtenerConceptosPresupuestoResponse()
        {
            ConceptosPresupuesto = new List<ConceptoPresupuestoViewModel>();
        }
    }
}