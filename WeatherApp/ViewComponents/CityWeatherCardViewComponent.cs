using Microsoft.AspNetCore.Mvc;
using WeatherApp.Interfaces;

namespace WeatherApp.ViewComponents
{
    public class CityWeatherCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ICityWeather cityWeather, bool isLinkToHome = false) 
        { 
            ViewBag.IsLinkToHome = isLinkToHome;
            return View(cityWeather);
        }
    }
}
