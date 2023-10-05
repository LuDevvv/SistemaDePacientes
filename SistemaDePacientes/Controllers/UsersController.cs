using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
