using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public class ConceptoPresupuestoMapper
    {
        public static ConceptoPresupuesto ToEntity(ConceptoPresupuesto dto)
        {
            var conceptoPresupuesto = new ConceptoPresupuesto();
            conceptoPresupuesto.Id = dto.Id;
            conceptoPresupuesto.Codigo = dto.Codigo;
            conceptoPresupuesto.Descripcion = dto.Descripcion;

            return conceptoPresupuesto;
        }

        public static ConceptoPresupuestoViewModel ToViewModel(ConceptoPresupuesto conceptoPresupuesto)
        {
            var viewModel = new ConceptoPresupuestoViewModel();
            viewModel.Id = conceptoPresupuesto.Id;
            viewModel.Codigo = conceptoPresupuesto.Codigo;
            viewModel.Descripcion = conceptoPresupuesto.Descripcion;
            return viewModel;
        }
    }
}
