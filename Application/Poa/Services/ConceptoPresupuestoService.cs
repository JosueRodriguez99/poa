using System.Linq;
using Application.Poa.MapperExtensionMethods;
using Application.Poa.Responses;
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
        public ObtenerConceptosPresupuestoResponse ObtenerConceptosPresupuesto()
        {
            var response = new ObtenerConceptosPresupuestoResponse();
            var conceptosPresupuesto = _repository.GetAll().ToList();

            foreach (var conceptoPresupuesto in conceptosPresupuesto)
                response.ConceptosPresupuesto.Add(conceptoPresupuesto.ToViewModel());
            
            return response;
        }
    }
}