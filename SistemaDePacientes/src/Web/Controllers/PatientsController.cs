using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.src.Web.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
