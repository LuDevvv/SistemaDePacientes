using Microsoft.AspNetCore.Mvc;

namespace SistemaDePacientes.src.Web.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
