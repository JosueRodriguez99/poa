using System;
using System.Web.Mvc;
using Application.Poa.Requests;
using Application.Poa.Services;
using Application.Poa.ViewModels;
using Presentation.Models.Poa;

namespace Presentation.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoService _productoService;
        private readonly IProgramaEstrategicoService _programaEstrategicoService;

        public ProductosController(IProductoService productoService, IProgramaEstrategicoService programaEstrategicoService)
        {
            if (productoService == null) throw new ArgumentNullException("productoService");
            if (programaEstrategicoService == null) throw new ArgumentNullException("programaEstrategicoService");

            _productoService = productoService;
            _programaEstrategicoService = programaEstrategicoService;
        }

        // GET: /Productos/
        public ActionResult Index()
        {
            var response = _productoService.ObtenerProductos();
            var pageView = new IndexProductoPageView();
            pageView.ProductoViewModels = response.Productos;
            return View(pageView);
        }

        // GET: /Productos/Create
        public ActionResult Create()
        {
            var response = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            var pageView = new CreateProductoPageView {ProgramaEstrategicoViewModels = response.ProgramasEstrategicos};
            return View(pageView);
        }

        // POST: /Productos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var request = new CrearProductoRequest();
                var viewModel = new ProductoViewModel
                {
                    Codigo = collection["Codigo"],
                    Descripcion = collection["Descripcion"],
                    Estado = (collection["Activo"] == "on") ? "Activo" : "Inactivo"
                };
                request.ProductoViewModel = viewModel;
                request.ProgramaEstrategicoId = Convert.ToInt32(collection["ProgramaEstrategicoId"]);
                _productoService.CrearProducto(request);
                return RedirectToAction("Index");
            }
            catch
            {
                var response = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                var pageView = new CreateProductoPageView { ProgramaEstrategicoViewModels = response.ProgramasEstrategicos };
                return View(pageView);
            }
        }

        // GET: /Productos/Edit/5
        public ActionResult Edit(int id)
        {
            var programaEstrategicoResponse = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            var productoResponse = _productoService.ObtenerProductoPorId(id);
            var pageView = new EditProductoPageView
            {
                ProgramaEstrategicoViewModels = programaEstrategicoResponse.ProgramasEstrategicos,
                ProductoViewModel = productoResponse.ProductoViewModel
            };
            return View(pageView);
        }

        // POST: /Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var viewModel = new ProductoViewModel
                {
                    Codigo = collection["Codigo"],
                    Descripcion = collection["Descripcion"],
                    Estado = (collection["Activo"] == "on") ? "Activo" : "Inactivo"
                };
                var request = new ActualizarProductoRequest();
                request.ProductoViewModel = viewModel;
                request.ProgramaEstrategicoId = Convert.ToInt32(collection["ProgramaEstrategicoId"]);
                _productoService.ActualizarProducto(request);
                return RedirectToAction("Index");
            }
            catch
            {
                var programaEstrategicoResponse = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                var productoResponse = _productoService.ObtenerProductoPorId(id);
                var pageView = new EditProductoPageView
                {
                    ProgramaEstrategicoViewModels = programaEstrategicoResponse.ProgramasEstrategicos,
                    ProductoViewModel = productoResponse.ProductoViewModel
                };
                return View(pageView);
            }
        }

        // GET: /Productos/Delete/5
        public ActionResult Delete(int id)
        {
            var request = new EliminarProductoRequest();
            request.ProductoId = id;
            _productoService.EliminarProducto(request);
            return RedirectToAction("Index");
        }

        // POST: /Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}