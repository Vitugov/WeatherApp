using WeatherApp.Interfaces;
using WeatherApp.Models;
using WeatherApp.Services.BusinessLogic;
using WeatherApp.Services.ViewServices;

namespace WeatherApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddSingleton<IRandomStyleService, RandomStyleService>();
            builder.Services.AddScoped<ICityWeatherService, CityWeatherService>();
            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();

            app.Run();
        }
    }
}
