using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using System.Drawing.Drawing2D;

namespace MyApp.Controllers
{
    public class WeatherAppController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var apiKey = "1e1652b4565d15738155d3020febd4b1";
            var CityWeathers = new List<WeatherModel>();

            List<string> Cities = new List<string>();
            Cities.Add("sakarya");
            Cities.Add("istanbul");
            Cities.Add("izmir");
            Cities.Add("ankara");


            var _httpClient = new HttpClient();

            foreach (var city in Cities)
            {
                var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}");
                var WeatherJson = await response.Content.ReadAsStringAsync();
                var CityObject = WeatherModel.FromJson(WeatherJson);

                CityWeathers.Add(CityObject);
            }


            return View(CityWeathers);
        }
    }
}
