using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Services.BusinessLogic
{
    public class CityWeatherService : ICityWeatherService
    {
        public List<ICityWeather> GetCityWeather()
        {
            return [
                new CityWeather("LDN", "London", new DateTime(2030, 1, 1, 8, 0, 0), 33),
                new CityWeather("NYC", "New York", new DateTime(2030, 1, 1, 3, 0, 0), 60),
                new CityWeather("PAR", "Paris", new DateTime(2030, 1, 1, 9, 0, 0), 82),
                new CityWeather("MOS", "Moscow", new DateTime(2030, 1, 1, 10, 0, 0), 72),
            ];
        }

        public ICityWeather GetCityWeather(string cityUniqueCode)
        {
            return GetCityWeather()
                .Where(cityWeather => cityWeather.CityUniqueCode == cityUniqueCode)
                .FirstOrDefault() ?? new CityWeather(cityUniqueCode);
        }
    }
}
