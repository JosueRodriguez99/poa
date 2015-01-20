using Application.Poa.Requests;
using Application.Poa.Responses;

namespace Application.Poa.Services
{
    public interface IProductoService
    {
        void CrearProducto(CrearProductoRequest request);
        void ActualizarProducto(ActualizarProductoRequest request);
        void EliminarProducto(EliminarProductoRequest request);
        ObtenerProductoPorIdResponse ObtenerProductoPorId(int id);
        ObtenerProductosResponse ObtenerProductos();
        ObtenerProductosResponse ObtenerProductosActivos();
    }
}