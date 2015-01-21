using System.Collections.Generic;
using System.Linq;
using Application.Poa.Dto;
using Application.Poa.Mappers;
using Application.Poa.ViewModels;
using Domain.Poa;
using System;
using Infrastructure.NHibernate;

namespace Application.Poa.Services
{
    public class ProductoService : IProductoService
    {
        protected readonly IProductoRepository ProductoRepository;
        protected readonly IProgramaEstrategicoRepository ProgramaEstrategicoRepository;

        public ProductoService(IProductoRepository productoRepository, IProgramaEstrategicoRepository programaEstrategicoRepository)
        {
            if (programaEstrategicoRepository == null) throw new ArgumentNullException("programaEstrategicoRepository");
            if (productoRepository == null) throw new ArgumentNullException("productoRepository");

            ProductoRepository = productoRepository;
            ProgramaEstrategicoRepository = programaEstrategicoRepository;
        }

        [UnitOfWork]
        public void CrearProducto(ProductoDto request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var programaEstrategico = ProgramaEstrategicoRepository.Get(request.ProgramaEstrategicoId);
            programaEstrategico.AgregarProducto(request.ToProducto());
            ProgramaEstrategicoRepository.Update(programaEstrategico);
        }

        [UnitOfWork]
        public void ActualizarProducto(ProductoDto request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var producto = request.ToProducto();
            producto.ProgramaEstrategico = ProgramaEstrategicoRepository.Get(request.ProgramaEstrategicoId);
            ProductoRepository.Update(producto);
        }

        public void EliminarProducto(int id)
        {
            ProductoRepository.Delete(id);
        }

        public ProductoViewModel ObtenerProductoPorId(int id)
        {
            return ProductoRepository.Get(id).ToViewModel();
        }

        [UnitOfWork]
        public List<ProductoViewModel> ObtenerProductos()
        {
            var productoViewModels = new List<ProductoViewModel>();
            var productosGuardados = ProductoRepository.GetAll().ToList();

            foreach (var productoGuardado in productosGuardados)
                productoViewModels.Add(productoGuardado.ToViewModel());

            return productoViewModels;
        }

        [UnitOfWork]
        public List<ProductoViewModel> ObtenerProductosActivos()
        {
            var productoViewModels = new List<ProductoViewModel>();
            var productosGuardados = ProductoRepository.GetAll().Where(x => x.Activo).ToList();

            foreach (var productoGuardado in productosGuardados)
                productoViewModels.Add(productoGuardado.ToViewModel());

            return productoViewModels;

        }
    }
}