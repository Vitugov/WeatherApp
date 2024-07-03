
namespace WeatherApp.Interfaces
{
    public interface ICityWeatherService
    {
        public List<ICityWeather> GetCityWeather();
        public ICityWeather GetCityWeather(string cityUniqueCode);
    }
}
