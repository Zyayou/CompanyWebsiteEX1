using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
