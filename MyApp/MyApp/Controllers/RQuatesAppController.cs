using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class RQuatesAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
