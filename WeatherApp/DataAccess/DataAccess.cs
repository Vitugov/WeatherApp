using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.DataAccess
{
    public static class DataAccess
    {
        public static List<CityWeather> GetCityWeatherList()
        {
            return [
                new("LDN", "London", new DateTime(2030, 1, 1, 8, 0, 0), 33),
                new("NYC", "New York", new DateTime(2030, 1, 1, 3, 0, 0), 60),
                new("PAR", "Paris", new DateTime(2030, 1, 1, 9, 0, 0), 82),
                new("PAR", "Paris", new DateTime(2030, 1, 1, 9, 0, 0), 82),
            ];
        }

        public static CityWeather GetCityWeather(string cityUniqueCode)
        {
            return GetCityWeatherList()
                .Where(cityWeather => cityWeather.CityUniqueCode == cityUniqueCode)
                .FirstOrDefault() ?? new(cityUniqueCode);
        }
    }
}
