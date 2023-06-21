using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class RQuotesAppController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var apiUrl = "https://api.quotable.io/random";
           

        

            var _httpClient = new HttpClient();

            var response = await _httpClient.GetAsync($"{apiUrl}");
            var quoteJson = await response.Content.ReadAsStringAsync();
            var quoteObject = RQuotesModel.FromJson(quoteJson);

            return View(quoteObject);
        }
    }
}
