using Domain.Poa;
using Infrastructure.NHibernate;
using System.Linq;

namespace Infrastructure.Poa.Repositories
{
    public class ProductoRepository : NhRepositoryBase<Producto, int>, IProductoRepository
    {
        public void Delete(ProgramaEstrategico programaEstrategico)
        {
            var productos = GetAll().Where(x => x.ProgramaEstrategico.Id == programaEstrategico.Id);

            foreach (var producto in productos)
            {
                Delete(producto.Id);
            }
        }
    }
}