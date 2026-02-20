using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
