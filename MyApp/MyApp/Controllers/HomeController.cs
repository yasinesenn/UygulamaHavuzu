using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using System.Diagnostics;
using System.Security.Policy;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var apps = new List<AppModel>();

            var bmiApp = new AppModel()
            {
                Title = "BmiApp",
                Description = "Bu uygulama ile vücut kitle endekinizi hesaplayabilirsiniz. ",
                Img = "img/bmi.jpg",
                Url = "/BMIapp"
            };
            apps.Add(bmiApp);

            var toDoApp = new AppModel()
            {
                Title = "ToDoApp",
                Description = "Bu uygulama ile yapılacaklar listesi olusturabilirsiniz. ",
                Img = "img/todo.png",
                Url = "/TODOapp"
            };
            apps.Add(toDoApp);

            var weatherApp = new AppModel()
            {
                Title = "WeatherApp",
                Description = "Bu uygulama ile hava durumunu kontrol edebilirsiniz. ",
                Img = "img/weather.jpg",
                Url = "/WEATHERapp"
            };
            apps.Add(weatherApp);

            var RQuatesApp = new AppModel()
            {
                Title = "RandomQuatesApp",
                Description = "Bu uygulama ile karışık özlü sözler okuyabilirsiniz. ",
                Img = "img/quates.jpg",
                Url = "/RQUATESapp"
            };
            apps.Add(RQuatesApp);

            return View(apps);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}