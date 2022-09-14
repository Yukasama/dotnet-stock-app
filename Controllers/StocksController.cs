using Microsoft.AspNetCore.Mvc;

namespace Obliviate.Controllers
{
    public class StocksController : Controller
    {
        public IActionResult Symbol()
        {
            return View();
        }
    }
}
