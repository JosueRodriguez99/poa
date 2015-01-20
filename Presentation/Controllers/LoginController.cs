using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}