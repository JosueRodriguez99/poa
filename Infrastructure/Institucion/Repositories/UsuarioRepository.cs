using Domain.Institucion;
using Infrastructure.NHibernate;

namespace Infrastructure.Institucion.Repositories
{
    public class UsuarioRepository : NhRepositoryBase<Usuario, int>, IUsuarioRepository
    {

    }
}