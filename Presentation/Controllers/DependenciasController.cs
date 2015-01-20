using System;
using System.Web.Mvc;
using Application.Institucion.Requests;
using Application.Institucion.Services;
using Application.Institucion.ViewModel;
using Presentation.Models.Poa;

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

            var response = _dependenciaService.ObtenerDependencias();
            return View(response.Dependencias);
        }

        // GET: /Dependencias/Create
        public ActionResult Create()
        {
            var pageView = new CreateDependenciaPageView();
            var jefes = _usuarioService.ObtenerJefes();
            var analistas = _usuarioService.ObtenerAnalistas();
            var dependencias = _dependenciaService.ObtenerDependenciasActivas();
            pageView.JefeViewModels = jefes.Usuarios;
            pageView.AnalistaViewModels = analistas.Usuarios;
            pageView.DependenciaViewModels = dependencias.Dependencias;
            return View(pageView);
        }

        // POST: /Dependencias/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Dependencias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Dependencias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Dependencias/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: /Dependencias/Delete/5
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
