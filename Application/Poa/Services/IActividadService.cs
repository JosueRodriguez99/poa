using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    public interface IActividadService
    {
        void AgregarTarea(TareaDto dto);
        void AgregarIndicador(int actividadId, IndicadorActividadDto dto);
        List<ActividadViewModel> ObtenerActividades(int poaId);
    }
}