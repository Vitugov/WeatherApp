using Microsoft.AspNetCore.Mvc;
using WeatherApp.Interfaces;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private ICityWeatherService _cityWeatherService {  get; }
        public HomeController(ICityWeatherService cityWeatherService)
        {
            _cityWeatherService = cityWeatherService;
        }
       
        [Route("/")]
        [Route("/weather/")]
        public IActionResult Index()
        {
            var weatherList = _cityWeatherService.GetCityWeather();
            return View(weatherList);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult CityWeather(string cityCode)
        {
            var city = _cityWeatherService.GetCityWeather(cityCode);
            return View(city);
        }
    }
}
