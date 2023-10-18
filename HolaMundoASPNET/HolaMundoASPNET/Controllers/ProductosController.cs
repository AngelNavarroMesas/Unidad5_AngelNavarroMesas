using Microsoft.AspNetCore.Mvc;

namespace HolaMundoASPNET.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
