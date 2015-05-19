using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    public interface ITareaService
    {
        void CrearTarea(TareaDto request);
        void ActualizarTarea(TareaDto request);
        void EliminarTarea(int id);
        void AgregarIndicador(int tareaId, IndicadorTareaDto dto);
        TareaViewModel ObtenerTareaPorId(int id);
        List<TareaViewModel> ObtenerTareas();
        List<TareaViewModel> ObtenerTareasActivos();
    }
}
