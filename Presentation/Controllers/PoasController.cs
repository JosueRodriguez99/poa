using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{

    public class PoasController : Controller
    {
        //
        // GET: /Poas/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Poas/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Poas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Poas/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/Actividad

        public ActionResult Actividad()
        {
            return View();
        }

        //
        // POST: /Poas/Actividad

        [HttpPost]
        public ActionResult Actividad(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/Tarea

        public ActionResult Tarea()
        {
            return View();
        }

        //
        // POST: /Poas/Tarea

        [HttpPost]
        public ActionResult Tarea(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/IndicadorActividad

        public ActionResult IndicadorActividad()
        {
            return View();
        }

        //
        // POST: /Poas/IndicadorActividad

        [HttpPost]
        public ActionResult IndicadorActividad(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/IndicadorDeTarea

        public ActionResult IndicadorDeTarea()
        {
            return View();
        }

        //
        // POST: /Poas/IndicadorDeTarea

        [HttpPost]
        public ActionResult IndicadorDeTarea(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/Presupuesto

        public ActionResult Presupuesto()
        {
            return View();
        }

        //
        // POST: /Poas/Presupuesto

        [HttpPost]
        public ActionResult Presupuesto(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poas/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
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

        //
        // GET: /Poas/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
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
