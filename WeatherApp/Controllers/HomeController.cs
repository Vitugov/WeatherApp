using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            var weatherList = DataAccess.DataAccess.GetCityWeatherList();
            return View(weatherList);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult CityWeather(string cityCode)
        {
            var city = DataAccess.DataAccess.GetCityWeather(cityCode);
            return View(city);
        }
    }
}
