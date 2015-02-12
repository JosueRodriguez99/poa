using System;
using System.Web.Mvc;
using Application.Institucion.Dto;
using Application.Institucion.Services;

namespace Presentation.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuariosController(IUsuarioService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _service = service;
        }

        // GET: /Usuarios/
        public ActionResult Index()
        {
            var usuarios = _service.ObtenerUsuarios();
            return View(usuarios);
        }

        // GET: /Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Usuarios/Create
        [HttpPost]
        public ActionResult Create(UsuarioDto dto)
        {
            try
            {
                _service.CrearUsuario(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _service.ObtenerUsuarioPorId(id);
            return View(usuario);
        }

        // POST: /Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UsuarioDto dto)
        {
            try
            {
                dto.Id = id;
                _service.ActualizarUsuario(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                var usuario = _service.ObtenerUsuarioPorId(id);
                return View(usuario);
            }
        }

        // GET: /Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            _service.EliminarUsuario(id);
            return RedirectToAction("Index");
        }

        // POST: /Usuarios/Delete/5
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
