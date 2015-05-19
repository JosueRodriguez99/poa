using System;
using System.Web.Mvc;
using Application.Institucion.Services;
using Application.Poa.Dto;
using Application.Poa.Services;
using Domain.Institucion;
using Presentation.Models.Poa;

namespace Presentation.Controllers
{

    public class PoasController : Controller
    {
        private readonly IPoaService _poaService; 
        private readonly IProgramaEstrategicoService _programaEstrategicoService;
        private readonly IDependenciaService _dependenciaService;

        public PoasController(IPoaService poaService, IProgramaEstrategicoService programaEstrategicoService, IDependenciaService dependenciaService)
        {
            if (poaService == null) throw new ArgumentNullException("poaService");
            if (programaEstrategicoService == null) throw new ArgumentNullException("programaEstrategicoService");
            if (dependenciaService == null) throw new ArgumentNullException("dependenciaService");

            _poaService = poaService;
            _programaEstrategicoService = programaEstrategicoService;
            _dependenciaService = dependenciaService;
        }

        // GET: /Poas/
        public ActionResult Index()
        {
            var usuarioActual = (Usuario)System.Web.HttpContext.Current.Session["CurrentUSer"];
            //var poas = _poaService.ObtenerPoasPorDependencia(usuarioActual);
            return View();
        }

        // GET: /Poas/Create
        public ActionResult Create()
        {
            var usuarioActual = (Usuario)System.Web.HttpContext.Current.Session["CurrentUSer"];
            var dependencias = _dependenciaService.ObtenerDependenciasPorJefe(usuarioActual.Id);
            return View(dependencias);
        }

        // POST: /Poas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var id = Convert.ToInt16(collection["DependenciaId"]);
            try
            {
                var poaId = _poaService.CrearPoa(id);
                return RedirectToAction("Details", new { id = poaId });
            }
            catch
            {
                var usuarioActual = (Usuario)System.Web.HttpContext.Current.Session["CurrentUSer"];
                var dependencias = _dependenciaService.ObtenerDependenciasPorJefe(usuarioActual.Id);
                return View(dependencias);
            }
        }

        // GET: /Poas/Details/{5}
        public ActionResult Details(int id)
        {
            var poa = _poaService.ObtenerPoaPorId(id);
            var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
            var pageView = new CreatePoaPageView(poa, programasEstrategicos);
            return View(pageView);
        }

        // POST: /Poas/Details
        /*[HttpPost]
        public ActionResult Details(int dependeciaId)
        {
            try
            {
                _poaService.CrearPoa(dependeciaId);
                return RedirectToAction("Index");
            }
            catch
            {
                var poa = _poaService.ObtenerPoaPorId(id);
                var programasEstrategicos = _programaEstrategicoService.ObtenerProgramasEstrategicosActivos();
                var pageView = new CreatePoaPageView(programasEstrategicos, poa);
                return View(pageView);
            }
        }*/

        // GET: /Poas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Poas/Edit/5
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

        // GET: /Poas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Poas/Delete/5
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
