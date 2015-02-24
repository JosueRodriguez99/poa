using Application.Poa.Dto;
using Application.Poa.Services;
using System;
using System.Web.Mvc;

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
            var programasEstrategicos = _service.ObtenerProgramasEstrategicos();
            return View(programasEstrategicos);
        }

        // GET: /ProgramasEstrategicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ProgramasEstrategicos/Create
        [HttpPost]
        public ActionResult Create(ProgramaEstrategicoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            try
            {
                _service.CrearProgramaEstrategico(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }   
            
        }

        // GET: /ProgramasEstrategicos/Edit/5
        public ActionResult Edit(int id)
        {
            var programaEstrategico = _service.ObtenerProgramaEstrategicoPorId(id);
            return View(programaEstrategico);
        }

        // POST: /ProgramasEstrategicos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProgramaEstrategicoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            try
            {
                dto.Id = id;
                _service.ActualizarProgramaEstrategico(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }   
        }

        // GET: /ProgramasEstrategicos/Delete/5
        public ActionResult Delete(int id)
        {
            var programaEstrategico = _service.ObtenerProgramaEstrategicoPorId(id);
            return View(programaEstrategico);
        }

        // POST: /ProgramasEstrategicos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProgramaEstrategicoDto dto)
        {
            try
            {
                dto.Id = id;
                _service.EliminarProgramaEstrategico(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}