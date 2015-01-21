using System.Collections.Generic;
using System.Linq;
using Application.Poa.Mappers;
using Application.Poa.ViewModels;
using Domain.Poa;
using System;
using Infrastructure.NHibernate;

namespace Application.Poa.Services
{
    public class ConceptoPresupuestoService : IConceptoPresupuestoService
    {
        private readonly IConceptoPresupuestoRepository _repository;

        public ConceptoPresupuestoService(IConceptoPresupuestoRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
        }

        [UnitOfWork]
        public List<ConceptoPresupuestoViewModel> ObtenerConceptosPresupuesto()
        {
            var conceptoPresupuestoViewModels = new List<ConceptoPresupuestoViewModel>();
            var conceptosPresupuesto = _repository.GetAll().ToList();

            foreach (var conceptoPresupuesto in conceptosPresupuesto)
                conceptoPresupuestoViewModels.Add(conceptoPresupuesto.ToViewModel());
            
            return conceptoPresupuestoViewModels;
        }
    }
}