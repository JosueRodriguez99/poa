using System;
using System.Collections.Generic;
using System.Linq;
using Application.Poa.Dto;
using Application.Poa.Mappers;
using Application.Poa.ViewModels;
using Domain.Institucion;
using Domain.Poa;
using Infrastructure.NHibernate;

namespace Application.Poa.Services
{
    public class PoaService : IPoaService
    {
        private readonly IPoaRepository _poaRepository;
        private readonly IDependenciaRepository _dependenciaRepository;
        private readonly IConceptoPresupuestoRepository _conceptoPresupuestoRepository;

        public PoaService(IPoaRepository poaRepository, IDependenciaRepository dependenciaRepository, 
            IConceptoPresupuestoRepository conceptoPresupuestoRepository)
        {
            if (poaRepository == null) throw new ArgumentNullException("poaRepository");
            if (dependenciaRepository == null) throw new ArgumentNullException("dependenciaRepository");
            if (conceptoPresupuestoRepository == null) throw new ArgumentNullException("conceptoPresupuestoRepository");

            _poaRepository = poaRepository;
            _dependenciaRepository = dependenciaRepository;
            _conceptoPresupuestoRepository = conceptoPresupuestoRepository;
        }

        [UnitOfWork]
        public void CrearPoa(int dependenciaId)
        {
            var poa = new Domain.Poa.Poa();
            poa.Version = 1;
            poa.Dependencia = _dependenciaRepository.Get(dependenciaId);
            poa.Estado = EstadoPoa.Guardado;
            _poaRepository.Insert(poa);
        }

        [UnitOfWork]
        public void AgregarActividad(ActividadDto dto)
        {
            var poa = _poaRepository.Get(dto.PoaId);
            poa.AgregarActividad(dto.ToEntity());
            _poaRepository.Update(poa);
        }

        [UnitOfWork]
        public void AgregarPresupuesto(PresupuestoDto dto)
        {
            var poa = _poaRepository.Get(dto.PoaId);
            var presupuesto = new Presupuesto();
            presupuesto.ConceptoPresupuesto = _conceptoPresupuestoRepository.Get(dto.ConceptoPresupuestoId);
            presupuesto.Monto = dto.Monto;
            _poaRepository.Update(poa);
        }

        [UnitOfWork]
        public void EliminarPoa(int id)
        {
            var poa = _poaRepository.Get(id);
            if (poa.Estado == EstadoPoa.Guardado)
                _poaRepository.Delete(id);
        }

        [UnitOfWork]
        public void EnviarPoa(int id)
        {
            var poa = _poaRepository.Get(id);
            poa.Enviar();
            _poaRepository.Update(poa);
        }

        public PoaViewModel ObtenerPoaPorId(int id)
        {
            return _poaRepository.Get(id).ToViewModel();
        }

        [UnitOfWork]
        public List<PoaViewModel> ObtenerPoasPorDependencia(int dependenciaId)
        {
            var poasViewModels = new List<PoaViewModel>();
            var poas = _poaRepository.GetAll().Where(x => x.Dependencia.Id == dependenciaId).ToList();

            foreach (var poa in poas)
                poasViewModels.Add(poa.ToViewModel());

            return poasViewModels;
        }
    }
}
