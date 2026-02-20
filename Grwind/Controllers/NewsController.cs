using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
