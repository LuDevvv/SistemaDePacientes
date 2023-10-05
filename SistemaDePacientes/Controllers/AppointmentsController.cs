using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
