using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class PoaController : Controller
    {
        //
        // GET: /Poa/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Poa/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Poa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Poa/Create

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
        // GET: /Poa/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Poa/Edit/5

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
        // GET: /Poa/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Poa/Delete/5

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
