﻿using WeatherApp.Interfaces;
namespace WeatherApp.Models
{
    public class CityWeather(string cityUniqueCode = "", string cityName = "",
        DateTime? dateAndTime = null, int temperatureFahrenheit = 0) : ICityWeather
    {
        public string CityUniqueCode { get; set; } = cityUniqueCode;
        public string CityName { get; set; } = cityName;
        public DateTime DateAndTime { get; set; } = dateAndTime ?? new(1,1,1,0,0,0);
        public int TemperatureFahrenheit { get; set; } = temperatureFahrenheit;

        public string Time => DateAndTime.ToString("t");
        public string Date => DateAndTime.ToString("dd MMM yyyy");
    }
}
