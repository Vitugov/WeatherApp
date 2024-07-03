using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.ViewComponents
{
    public class CityWeatherCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather, bool isLinkToHome = false) 
        { 
            ViewBag.IsLinkToHome = isLinkToHome;
            return View(cityWeather);
        }
    }
}
