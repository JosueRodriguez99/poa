using Application.Poa.MapperExtensionMethods;
using Application.Poa.Requests;
using Application.Poa.Responses;
using System;
using Domain.Poa;

namespace Application.Poa.Services
{
    public class PoaService : IPoaService
    {
        protected readonly IPoaRepository PoaRepository;
        protected readonly IConceptoPresupuestoRepository ConceptoPresupuestoRepository;

        public PoaService(IPoaRepository repository, IConceptoPresupuestoRepository conceptoPresupuestoRepository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            if (conceptoPresupuestoRepository == null) throw new ArgumentNullException("conceptoPresupuestoRepository");

            PoaRepository = repository;
            ConceptoPresupuestoRepository = conceptoPresupuestoRepository;
        }

        public void CrearPoa(CrearPoaRequest request)
        {
            var poa = request.PoaViewModel.ToEntity();
            PoaRepository.Insert(poa);
        }

        public void AgregarActividad(AgregarActividadRequest request)
        {
            var poa = PoaRepository.Get(request.PoaId);
            var actividad = request.ActividadViewModel.ToEntity();
            poa.AgregarActividad(actividad);
            PoaRepository.Update(poa);
        }

        public void AgregarPresupuesto(AgregarPresupuestoRequest request)
        {
            var poa = PoaRepository.Get(request.PoaId);
            var conceptoPresupuesto = ConceptoPresupuestoRepository.Get(request.ConceptoPresupuestoId);
            //var presupuesto = request.Presupuesto.ToEntity();
            //presupuesto.ConceptoPresupuesto = conceptoPresupuesto;
            //poa.AgregarPresupuesto(presupuesto);
            PoaRepository.Update(poa);
        }

        public void AgregarIndicadorActividad(AgregarIndicadorActividadRequest request)
        {
            
        }

        public void AgregarTarea(AgregarTareaRequest request)
        {
                
        }

        public void AgregarIndicadorTarea(AgregarIndicadorTareaRequest request)
        {
            
        }

        public void AgregarProgramacionActividad(AgregarProgramacionActividadRequest request)
        {
            
        }

        public void AgregarProgramacionTarea(AgregarProgramacionTareaRequest request)
        {
            
        }

        public void AgregarEjecucionActividad(AgregarEjecucionActividadRequest request)
        {
            
        }

        public void AgregarEjecucionTarea(AgregarEjecucionTareaRequest request)
        {
            
        }

        public ObtenerTodosLosPoaResponse ObtenerTodosLosPoa()
        {
            throw new NotImplementedException();
        }

        public ObtenerPoaPorDependenciaResponse ObtenerPoaPorDependencia(ObtenerPoaPorDependenciaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
