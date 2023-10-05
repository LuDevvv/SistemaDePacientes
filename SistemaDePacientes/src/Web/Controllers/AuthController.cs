using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.src.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
