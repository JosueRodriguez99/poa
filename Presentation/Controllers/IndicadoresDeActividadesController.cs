using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;
using Presentation.Models.Poa;

namespace Presentation.Controllers
{
    public class IndicadoresDeActividadesController : Controller
    {
        private readonly IActividadService _actividadService;

        public IndicadoresDeActividadesController(IActividadService actividadService)
        {
            if (actividadService == null) throw new ArgumentNullException("actividadService");

            _actividadService = actividadService;
        }
        //
        // GET: /IndicadoresDeActividades/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /IndicadoresDeActividades/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /IndicadoresDeActividades/Create

        public ActionResult Create()
        {   
            //var actividades = _actividadService.ObtenerActividades();
            return View();
        }

        //
        // POST: /IndicadoresDeActividades/Create

        [HttpPost]
        public ActionResult Create(IndicadorActividadDto dto)
        {
            try
            {
                //_actividadService.AgregarIndicador(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                //var actividades = _actividadService.ObtenerActividades();
                return View();
            }
        }

        //
        // GET: /IndicadoresDeActividades/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /IndicadoresDeActividades/Edit/5

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
        // GET: /IndicadoresDeActividades/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /IndicadoresDeActividades/Delete/5

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
