using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class NewsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
