using Microsoft.AspNetCore.Mvc;

namespace Grwind.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
