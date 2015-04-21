using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class PresupuestoMapper
    {
        public static Presupuesto ToEntity(this PresupuestoDto dto)
        {
            var presupuesto = new Presupuesto();
            presupuesto.Id = dto.Id;
            presupuesto.Monto = dto.Monto;

            return presupuesto;
        }

        public static PresupuestoViewModel ToViewModel(Presupuesto presupuesto)
        {
            var viewModel = new PresupuestoViewModel();
            viewModel.Id = presupuesto.Id;
            viewModel.ConceptoPresupuesto = presupuesto.ConceptoPresupuesto.Id;
            viewModel.Monto = presupuesto.Monto;
            viewModel.ProgramaEstrategico = presupuesto.ProgramaEstrategico.Nombre;

            return viewModel;
        }
    }
}
