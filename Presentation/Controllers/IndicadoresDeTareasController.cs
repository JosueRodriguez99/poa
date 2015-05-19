using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;
using Presentation.Models.Poa;

namespace Presentation.Controllers
{
    public class IndicadoresDeTareasController : Controller
    {
        private readonly ITareaService _tareaService;

        public IndicadoresDeTareasController(ITareaService tareaService)
        {
            if (tareaService == null) throw new ArgumentNullException("tareaService");

            _tareaService = tareaService;
        }
        //
        // GET: /IndicadoresDeTareas/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /IndicadoresDeTareas/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /IndicadoresDeTareas/Create

        public ActionResult Create()
        {
            var tareas = _tareaService.ObtenerTareas();
            return View(tareas);
        }

        //
        // POST: /IndicadoresDeTareas/Create

        [HttpPost]
        public ActionResult Create(IndicadorTareaDto dto)
        {
            try
            {
                //_tareaService.AgregarIndicador(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var tareas = _tareaService.ObtenerTareas();
                return View(tareas);
            }
        }

        //
        // GET: /IndicadoresDeTareas/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /IndicadoresDeTareas/Edit/5

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
        // GET: /IndicadoresDeTareas/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /IndicadoresDeTareas/Delete/5

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
