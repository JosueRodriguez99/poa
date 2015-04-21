using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;
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
            var productos = _productoService.ObtenerProductos();
            return View(productos);
        }

        // GET: /Productos/Create
        public ActionResult Create()
        {
            var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            return View(programasEstrategicos);
        }

        // POST: /Productos/Create
        [HttpPost]
        public ActionResult Create(ProductoDto dto)
        {
            /*
            if (!ModelState.IsValid)
            {
                return View(dto);
            }*/

            try
            {
                _productoService.CrearProducto(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                return View(programasEstrategicos);
            }
        }

        // GET: /Productos/Edit/5
        public ActionResult Edit(int id)
        {
            var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            var producto = _productoService.ObtenerProductoPorId(id);
            var pageView = new EditProductoPageView(programasEstrategicos, producto);
            return View(pageView);
        }

        // POST: /Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductoDto dto)
        {
            try
            {
                dto.Id = id;
                _productoService.ActualizarProducto(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                var producto = _productoService.ObtenerProductoPorId(id);
                var pageView = new EditProductoPageView(programasEstrategicos, producto);
                return View(pageView);
            }
        }

        // GET: /Productos/Delete/5
        public ActionResult Delete(int id)
        {
            var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            var producto = _productoService.ObtenerProductoPorId(id);
            var pageView = new EditProductoPageView(programasEstrategicos, producto);
            return View(pageView);
        }

        // POST: /Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductoDto dto)
        {
            try
            {
                dto.Id = id;
                _productoService.EliminarProducto(id);
                return RedirectToAction("Index");
            }
            catch
            {
                var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                var producto = _productoService.ObtenerProductoPorId(id);
                var pageView = new EditProductoPageView(programasEstrategicos, producto);
                return View(pageView);
            }
        }
    }
}