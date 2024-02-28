using Microsoft.AspNetCore.Mvc;
using Refit.Mvc.Helpers;
using Refit.Mvc.Models;
using System.Diagnostics;
using System.Text.Json;

namespace Refit.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IApiService _apiService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var json = await _apiService.GetDatas();
            var response = JsonSerializer.Deserialize<List<Weather>>(json.Content);

            return View(response);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

public class WeatherList 
{
    public Weather[]? Weathers { get; set; }
}
public class Weather
{
    public string date { get; set; } = string.Empty;
    public int temperatureC { get; set; }
    public int temperatureF { get; set; }
    public string summary { get; set; } = string.Empty;
}

