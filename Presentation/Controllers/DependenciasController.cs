using System;
using System.Web.Mvc;
using Application.Institucion.Dto;
using Application.Institucion.Services;
using Presentation.Models.Institucion;

namespace Presentation.Controllers
{
    public class DependenciasController : Controller
    {
        private readonly IDependenciaService _dependenciaService;
        private readonly IUsuarioService _usuarioService;

        public DependenciasController(IDependenciaService service, IUsuarioService usuario)
        {
            if (service == null) throw new ArgumentNullException("service");
            if (usuario == null) throw new ArgumentNullException("usuario");

            _dependenciaService = service;
            _usuarioService = usuario;
        }

        // GET: /Dependencias/
        public ActionResult Index()
        {
            var dependencias = _dependenciaService.ObtenerDependencias();
            return View(dependencias);
        }

        // GET: /Dependencias/Create
        public ActionResult Create()
        {
            var jefes = _usuarioService.ObtenerJefes();
            var analistas = _usuarioService.ObtenerAnalistas();
            var dependencias = _dependenciaService.ObtenerDependenciasActivas();
            var pageView = new CreateDependenciaPageView(jefes, analistas, dependencias);
            return View(pageView);
        }

        // POST: /Dependencias/Create
        [HttpPost]
        public ActionResult Create(DependenciaDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            try
            {
                _dependenciaService.CrearDependencia(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var jefes = _usuarioService.ObtenerJefes();
                var analistas = _usuarioService.ObtenerAnalistas();
                var dependencias = _dependenciaService.ObtenerDependenciasActivas();
                var pageView = new CreateDependenciaPageView(jefes, analistas, dependencias);
                return View(pageView);
            }

        }

        // GET: /Dependencias/Edit/5
        public ActionResult Edit(int id)
        {
            var jefes = _usuarioService.ObtenerJefes();
            var analistas = _usuarioService.ObtenerAnalistas();
            var dependencias = _dependenciaService.ObtenerDependenciasActivas();
            var dependencia = _dependenciaService.ObtenerPorId(id);
            var pageView = new EditDependenciaPageView(jefes, analistas, dependencias, dependencia);
            return View(pageView);
        }

        // POST: /Dependencias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DependenciaDto dto)
        {
            try
            {
                dto.Id = id;
                _dependenciaService.ActualizarDependencia(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var jefes = _usuarioService.ObtenerJefes();
                var analistas = _usuarioService.ObtenerAnalistas();
                var dependencias = _dependenciaService.ObtenerDependenciasActivas();
                var dependencia = _dependenciaService.ObtenerPorId(id);
                var pageView = new EditDependenciaPageView(jefes, analistas, dependencias, dependencia);
                return View(pageView);
            }
        }

        // GET: /Dependencias/Delete/5
        public ActionResult Delete(int id)
        {
            var jefes = _usuarioService.ObtenerJefes();
            var analistas = _usuarioService.ObtenerAnalistas();
            var dependencias = _dependenciaService.ObtenerDependenciasActivas();
            var dependencia = _dependenciaService.ObtenerPorId(id);
            var pageView = new EditDependenciaPageView(jefes, analistas, dependencias, dependencia);
            return View(pageView);
        }

        // POST: /Dependencias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DependenciaDto dto)
        {
            try
            {
                dto.Id = id;
                _dependenciaService.EliminarDependencia(id);
                return RedirectToAction("Index");
            }
            catch
            {
                var jefes = _usuarioService.ObtenerJefes();
                var analistas = _usuarioService.ObtenerAnalistas();
                var dependencias = _dependenciaService.ObtenerDependenciasActivas();
                var dependencia = _dependenciaService.ObtenerPorId(id);
                var pageView = new EditDependenciaPageView(jefes, analistas, dependencias, dependencia);
                return View(pageView);
            }
        }
    }
}
