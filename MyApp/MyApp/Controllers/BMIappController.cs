using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MyApp.Controllers
{
    public class BMIappController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel appItem)
        {
            
            appItem.BMI = appItem.Weight /(float) Math.Pow(appItem.Height/100,2);

            if (appItem.BMI < 18) appItem.BMIRange = "Under-Weight";
            else if (appItem.BMI > 18 && appItem.BMI <= 24.9) appItem.BMIRange = "Healthy-Weight";
            else if (appItem.BMI > 24.9 && appItem.BMI <= 29.9) appItem.BMIRange = "Over-Weight";
            else if (appItem.BMI > 29.9) appItem.BMIRange = "Obese";


            var objectBMI = JsonConvert.SerializeObject(appItem);

            return Json(objectBMI);
        }

    }
}
