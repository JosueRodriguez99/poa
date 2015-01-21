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
    }
}
