using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class RQuotesAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
