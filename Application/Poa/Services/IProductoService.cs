using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.ViewModels;

namespace Application.Poa.Services
{
    public interface IProductoService
    {
        void CrearProducto(ProductoDto request);
        void ActualizarProducto(ProductoDto request);
        void EliminarProducto(int id);
        ProductoViewModel ObtenerProductoPorId(int id);
        List<ProductoViewModel> ObtenerProductos();
        List<ProductoViewModel> ObtenerProductosActivos();
        List<ProductoViewModel> ObtenerProductosPorProgramaEstrategico(int programaEstrategicoId);
    }
}