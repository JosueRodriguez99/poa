using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class ConceptoPresupuestoExtensionMethods
    {
        public static ConceptoPresupuestoViewModel ToViewModel(this ConceptoPresupuesto conceptoPresupuesto)
        {
            var viewModel = new ConceptoPresupuestoViewModel
            {
                Id = conceptoPresupuesto.Id,
                Codigo = conceptoPresupuesto.Codigo,
                Descripcion = conceptoPresupuesto.Descripcion
            };
            return viewModel;
        }

        public static ConceptoPresupuesto ToEntity(this ConceptoPresupuestoViewModel viewModel)
        {
            var conceptoPresupuesto = new ConceptoPresupuesto
            {
                Id = viewModel.Id,
                Codigo = viewModel.Codigo,
                Descripcion = viewModel.Descripcion
            };
            return conceptoPresupuesto;
        }
    }
}