using Application.Poa.Dto;
using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoViewModel ToViewModel(this Producto producto)
        {
            var viewModel = new ProductoViewModel();
            viewModel.Id = producto.Id;
            viewModel.Codigo = producto.Codigo;
            viewModel.Descripcion = producto.Descripcion;
            viewModel.ProgramaEstrategico = producto.ProgramaEstrategico.Nombre;
            viewModel.Estado = (producto.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }

        public static Producto ToProducto(this ProductoDto dto)
        {
            var producto = new Producto();
            producto.Id = dto.Id;
            producto.Codigo = dto.Codigo;
            producto.Descripcion = dto.Descripcion;
            producto.Activo = dto.Activo;
            return producto;
        }
    }
}