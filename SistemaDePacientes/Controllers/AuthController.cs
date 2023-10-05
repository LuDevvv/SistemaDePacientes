using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
