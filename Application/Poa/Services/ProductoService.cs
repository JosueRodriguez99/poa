﻿using System.Linq;
using Application.Poa.MapperExtensionMethods;
using Application.Poa.Requests;
using Application.Poa.Responses;
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
        public void CrearProducto(CrearProductoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var programaEstrategico = ProgramaEstrategicoRepository.Get(request.ProgramaEstrategicoId);
            programaEstrategico.AgregarProducto(request.ProductoViewModel.ToEntity());
            ProgramaEstrategicoRepository.Update(programaEstrategico);
        }

        [UnitOfWork]
        public void ActualizarProducto(ActualizarProductoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var producto = request.ProductoViewModel.ToEntity();
            producto.ProgramaEstrategico = ProgramaEstrategicoRepository.Get(request.ProgramaEstrategicoId);
            ProductoRepository.Update(producto);
        }

        public void EliminarProducto(EliminarProductoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            ProductoRepository.Delete(request.ProductoId);
        }

        public ObtenerProductoPorIdResponse ObtenerProductoPorId(int id)
        {
            var response = new ObtenerProductoPorIdResponse();
            response.ProductoViewModel = ProductoRepository.Get(id).ToViewModel();
            return response;
        }

        [UnitOfWork]
        public ObtenerProductosResponse ObtenerProductos()
        {
            var response = new ObtenerProductosResponse();
            var productosGuardados = ProductoRepository.GetAll().ToList();

            foreach (var productoGuardado in productosGuardados)
                response.Productos.Add(productoGuardado.ToViewModel());

            return response;
        }

        [UnitOfWork]
        public ObtenerProductosResponse ObtenerProductosActivos()
        {
            var response = new ObtenerProductosResponse();
            var productosGuardados = ProductoRepository.GetAll().Where(x => x.Activo).ToList();

            foreach (var productoGuardado in productosGuardados)
                response.Productos.Add(productoGuardado.ToViewModel());

            return response;
        }
    }
}