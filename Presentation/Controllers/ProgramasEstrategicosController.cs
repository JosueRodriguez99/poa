using Application.Poa.Requests;
using Application.Poa.Services;
using System;
using System.Web.Mvc;
using Application.Poa.ViewModels;
using Presentation.Models.Poa;

namespace Presentation.Controllers
{
    public class ProgramasEstrategicosController : Controller
    {
        private readonly IProgramaEstrategicoService _service;

        public ProgramasEstrategicosController(IProgramaEstrategicoService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _service = service;
        }

        // GET: /ProgramasEstrategicos/
        public ActionResult Index()
        {
            var response = _service.ObtenerProgramasEstrategicos();
            var pageView = new IndexProgramaEstrategicoPageView();
            pageView.ProgramaEstrategicoViewModels = response.ProgramasEstrategicos;
            return View(pageView);
        }

        // GET: /ProgramasEstrategicos/Create
        public ActionResult Create()
        {
            var pageView = new CreateProgramaEstrategicoPageView();
            return View(pageView);
        }

        // POST: /ProgramasEstrategicos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var request = new CrearProgramaEstrategicoRequest();
                var viewModel = new ProgramaEstrategicoViewModel();
                viewModel.Nombre = collection["Nombre"];
                viewModel.Descripcion = collection["Descripcion"];
                viewModel.Estado = (collection["Activo"] == "on") ? "Activo" : "Inactivo";
                request.ProgramaEstrategicoViewModel = viewModel;
                _service.CrearProgramaEstrategico(request);
                return RedirectToAction("Index");
            }
            catch
            {
                var pageView = new CreateProgramaEstrategicoPageView();
                return View(pageView);
            }
        }

        // GET: /ProgramasEstrategicos/Edit/5
        public ActionResult Edit(int id)
        {
            var response = _service.ObtenerProgramaEstrategicoPorId(id);
            var pageView = new EditProgramaEstrategicoPageView
            {
                ProgramaEstrategicoViewModel = response.ProgramaEstrategico
            };
            return View(pageView);
        }

        // POST: /ProgramasEstrategicos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var viewModel = new ProgramaEstrategicoViewModel
                {
                    Nombre = collection["Nombre"],
                    Descripcion = collection["Descripcion"],
                    Estado = (collection["Activo"] == "on") ? "Activo" : "Inactivo"
                };
                var request = new ActualizarProgramaEstrategicoRequest();
                request.ProgramaEstrategicoViewModel = viewModel;
                _service.ActualizarProgramaEstrategico(request);
                return RedirectToAction("Index");
            }
            catch
            {
                var response = _service.ObtenerProgramaEstrategicoPorId(id);
                var pageView = new EditProgramaEstrategicoPageView
                {
                    ProgramaEstrategicoViewModel = response.ProgramaEstrategico
                };
                return View(pageView);
            }   
        }

        // GET: /ProgramasEstrategicos/Delete/5
        public ActionResult Delete(int id)
        {
            var request = new EliminarProgramaEstrategicoRequest();
            request.ProgramaEstrategicoId = id;
            _service.EliminarProgramaEstrategico(request);
            return RedirectToAction("Index");
        }

        // POST: /ProgramasEstrategicos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}