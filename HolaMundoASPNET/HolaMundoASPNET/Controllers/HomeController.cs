using Microsoft.AspNetCore.Mvc;

namespace HolaMundoASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Apellidos()
        {
            return "Navarro Mesas";
        }

        public IActionResult Saludo()
        {
            return View();
        }
    }
}
