using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
