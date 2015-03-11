using System.Web.Mvc;
using Application.Institucion.Services;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public HomeController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: /Home/
        public ActionResult Index()
        {
            System.Web.HttpContext.Current.Session["CurrentUSer"] = _usuarioService.ComprobarUsuario(User.Identity.Name.Split('\\'));
            return View();
        }

    }
}