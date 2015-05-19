using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    public interface IPoaService
    {
        int CrearPoa(int dependenciaId);
        void AgregarActividad(ActividadDto dto);
        void AgregarPresupuesto(PresupuestoDto dto);
        void EliminarPoa(int id);
        void EnviarPoa(int id);
        PoaViewModel ObtenerPoaPorId(int id);
        List<PoaViewModel> ObtenerPoasPorDependencia(int dependenciaId);
    }
}