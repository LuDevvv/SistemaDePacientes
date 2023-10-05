using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
