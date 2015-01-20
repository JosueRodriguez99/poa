using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.MapperExtensionMethods
{
    public static class ProgramaEstrategicoExtensionMethods
    {
        public static ProgramaEstrategicoViewModel ToViewModel(this ProgramaEstrategico programaEstrategico)
        {
            var viewModel = new ProgramaEstrategicoViewModel();
            viewModel.Nombre = programaEstrategico.Nombre;
            viewModel.Descripcion = programaEstrategico.Descripcion;
            viewModel.Estado = (programaEstrategico.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }

        public static ProgramaEstrategico ToEntity(this ProgramaEstrategicoViewModel viewModel)
        {
            var programaEstrategico = new ProgramaEstrategico();
            programaEstrategico.Nombre = viewModel.Nombre;
            programaEstrategico.Descripcion = viewModel.Descripcion;
            programaEstrategico.Activo = (viewModel.Estado == "Activo");
            return programaEstrategico;
        }
    }
}