using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.src.Web.Controllers
{
    public class TestsLaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
