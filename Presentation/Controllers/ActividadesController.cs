using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;

namespace Presentation.Controllers
{
    public class ActividadesController : Controller
    {
        private readonly IActividadService _actividadService;
        private readonly IProductoService _productoService;

        public ActividadesController(IActividadService actividadService, IProductoService productoService)
        {
            if(actividadService == null) throw new ArgumentNullException("actividadService");
            if (productoService == null) throw new ArgumentNullException("productoService");
            
            _actividadService = actividadService;
            _productoService = productoService;
        }

        /*
        //GET: /Actividades/
        public ActionResult Index()
        {
            return View();
        }*/

        /*
        // GET: /Actividades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }*/

        // GET: /Actividades/Create
        public ActionResult Create()
        {
            var productos = _productoService.ObtenerProductosActivos();
            return View(productos);
        }

        // POST: /Actividades/Create
        [HttpPost]
        public ActionResult Create(ActividadDto dto)
        {
            try
            {
                var poa = (PoaDto)System.Web.HttpContext.Current.Session["Poa"];
                poa.Actividades.Add(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var productos = _productoService.ObtenerProductosActivos();
                return View(productos);
            }
        }

        /*
        // GET: /Actividades/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }
        */ 

        /*
        // POST: /Actividades/Edit/5
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
        */

        /*
        // GET: /Actividades/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }
        */ 

        /*
        // POST: /Actividades/Delete/5
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
        */
    }
}
