using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.src.Web.Controllers
{
    public class LaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
