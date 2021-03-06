﻿using System;
using System.Web.Mvc;
using Application.Poa.Dto;
using Application.Poa.Services;
using Presentation.Models.Poa;

using Application.Institucion.Services;namespace Presentation.Controllers
{
    public class ActividadesController : Controller
    {
        private readonly IActividadService _actividadService;
        private readonly IProductoService _productoService;
        private readonly IDependenciaService _dependenciaService;
        //private readonly IPoaService _poaService; 

        public ActividadesController(IActividadService actividadService, IProductoService productoService, IDependenciaService dependenciaService)
        {
            if (actividadService == null) throw new ArgumentNullException("actividadService");
            if (productoService == null) throw new ArgumentNullException("productoService");
            if (dependenciaService == null) throw new ArgumentNullException("dependenciaService");

            _actividadService = actividadService;
            _productoService = productoService;
            _dependenciaService = dependenciaService;
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
            var dependencias = _dependenciaService.ObtenerDependencias();
            var pageView = new ActividadPageView(productos, dependencias);
            return View(pageView);
        }

        // POST: /Actividades/Create
       /* [HttpPost]
        public ActionResult Create()
        {
            try
            {
                //_poaService.AgregarActividad(NuevaActividadDto);
                return RedirectToAction("Index");
            }
            catch
            {
                var productos = _productoService.ObtenerProductosActivos();
                var dependencias = _dependenciaService.ObtenerDependencias();
                var pageView = new ActividadPageView(productos, dependencias);
                return View(pageView);
            }
        }*/

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
