using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Poa.Dto;

namespace Presentation.Controllers
{
    public class PresupuestosController : Controller
    {
        // GET: /Presupuestos/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Presupuestos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: /Presupuestos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Presupuestos/Create
        [HttpPost]
        public ActionResult Create(PresupuestoDto dto)
        {
            try
            {
                var poa = (PoaDto)System.Web.HttpContext.Current.Session["Poa"];
                poa.Presupuestos.Add(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Presupuestos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Presupuestos/Edit/5
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

        // GET: /Presupuestos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Presupuestos/Delete/5
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
