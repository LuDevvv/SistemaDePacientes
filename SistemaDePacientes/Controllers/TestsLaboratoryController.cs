using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.Controllers
{
    public class TestsLaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
