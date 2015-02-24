using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class HabilitarEnviosPoaController : Controller
    {
        //
        // GET: /HabilitarEnviosPoa/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HabilitarEnviosPoa/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /HabilitarEnviosPoa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HabilitarEnviosPoa/Create

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
        // GET: /HabilitarEnviosPoa/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HabilitarEnviosPoa/Edit/5

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
        // GET: /HabilitarEnviosPoa/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HabilitarEnviosPoa/Delete/5

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
