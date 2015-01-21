using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class ProgramaEstrategicoMapper
    {
        public static ProgramaEstrategico ToProgramaEstrategico(this ProgramaEstrategicoDto dto)
        {
            var programaEstrategico = new ProgramaEstrategico();
            programaEstrategico.Id = dto.Id;
            programaEstrategico.Nombre = dto.Nombre;
            programaEstrategico.Descripcion = dto.Descripcion;
            programaEstrategico.Activo = dto.Activo;
            return programaEstrategico;
        }

        public static ProgramaEstrategicoViewModel ToViewModel(this ProgramaEstrategico programaEstrategico)
        {
            var viewModel = new ProgramaEstrategicoViewModel();
            viewModel.Nombre = programaEstrategico.Nombre;
            viewModel.Descripcion = programaEstrategico.Descripcion;
            viewModel.Estado = (programaEstrategico.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }
    }
}