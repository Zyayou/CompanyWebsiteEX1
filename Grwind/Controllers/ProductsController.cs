using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
