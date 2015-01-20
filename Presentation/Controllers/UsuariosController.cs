using System;
using System.Web.Mvc;
using Application.Institucion.Requests;
using Application.Institucion.Services;
using Application.Institucion.ViewModel;
using Domain.Institucion;

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
            var response = _service.ObtenerUsuarios();
            return View(response.Usuarios);
        }

        // GET: /Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Usuarios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                var viewModel = new UsuarioViewModel();
                viewModel.NombreUsuario = collection["Usuario"];
                viewModel.Estado = (collection["Activo"] == "on") ? "Activo" : "Inactivo";
                viewModel.RolUsuario = ((RolUsuario)Convert.ToInt32(collection["RolUsuarioId"])).ToString();
                
                var request = new CrearUsuarioRequest(viewModel);
                _service.CrearUsuario(request);
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
            var usuarioResponse = _service.ObtenerUsuarioPorId(id);
            return View(usuarioResponse.UsuarioViewModel);
        }

        // POST: /Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                var usuarioResponse = _service.ObtenerUsuarioPorId(id);
                return View(usuarioResponse.UsuarioViewModel);
            }
        }

        // GET: /Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Usuarios/Delete/5
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
