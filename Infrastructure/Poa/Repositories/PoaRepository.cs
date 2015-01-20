using Domain.Poa;
using Infrastructure.NHibernate;

namespace Infrastructure.Poa.Repositories
{
    public class PoaRepository : NhRepositoryBase<Domain.Poa.Poa, int>, IPoaRepository
    {
        
    }
}