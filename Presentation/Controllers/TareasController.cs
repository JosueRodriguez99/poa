using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;
using Presentation.Models.Poa;
using Application.Institucion.Services;

namespace Presentation.Controllers
{
    public class TareasController : Controller
    {
        private readonly IActividadService _actividadService;
        private readonly IDependenciaService _dependenciaService;

        public TareasController(IActividadService actividadService, IDependenciaService dependenciaService)
        {
            if (actividadService == null) throw new ArgumentNullException("actividadService");
            if (dependenciaService == null) throw new ArgumentNullException("dependenciaService");

            _actividadService = actividadService;
            _dependenciaService = dependenciaService;
        }

        //
        // GET: /Tareas/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Tareas/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Tareas/Create

        public ActionResult Create()
        {
            //var actividades = _actividadService.ObtenerActividades();
            //var dependencias = _dependenciaService.ObtenerDependencias();
            //var pageView = new ActividadPageView(actividades, dependencias);
            return View();
        }

        //
        // POST: /Tareas/Create

        [HttpPost]
        public ActionResult Create(TareaDto dto)
        {
            try
            {
               return RedirectToAction("Index");
            }
            catch
            {
               // var poa = (PoaDto)System.Web.HttpContext.Current.Session["Poa"];
               // var actividades = _actividadService.ObtenerActividades(poa);
               // var dependencias = _dependenciaService.ObtenerDependencias();
               // var pageView = new ActividadPageView(actividades, dependencias);
               return View();
            }
        }

        //
        // GET: /Tareas/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tareas/Edit/5

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

        //
        // GET: /Tareas/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tareas/Delete/5

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
