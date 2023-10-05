using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class LaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
