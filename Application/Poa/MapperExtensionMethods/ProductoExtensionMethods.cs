using Application.Poa.ViewModels;
using Domain.Poa;

namespace Application.Poa.MapperExtensionMethods
{
    public static class ProductoExtensionMethods
    {
        public static ProductoViewModel ToViewModel(this Producto producto)
        {
            var viewModel = new ProductoViewModel();
            viewModel.Codigo = producto.Codigo;
            viewModel.Descripcion = producto.Descripcion;
            viewModel.ProgramaEstrategico = producto.ProgramaEstrategico.Nombre;
            viewModel.Estado = (producto.Activo) ? "Activo" : "Inactivo";
            return viewModel;
        }

        public static Producto ToEntity(this ProductoViewModel viewModel)
        {
            var producto = new Producto();
            producto.Codigo = viewModel.Codigo;
            producto.Descripcion = viewModel.Descripcion;
            producto.Activo = (viewModel.Estado == "Activo");
            return producto;
        }
    }
}