using System.Collections.Generic;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    interface IConceptoPresupuestoService
    {
        List<ConceptoPresupuestoViewModel> ObtenerConceptosPresupuesto();
    }
}