namespace WeatherApp.Infrastructure
{
    public class RandomStyle
    {
        private List<string> styleList { get; } = [ "widget-49-date-primary", "widget-49-date-success", "widget-49-date-info",
        "widget-49-date-warning", "widget-49-date-danger", "widget-49-date-dark", "widget-49-date-base"];
        private Random Random { get; } = new();
        public string Get() => styleList[GetRandom()];
        private int GetRandom() => Random.Next(styleList.Count);
    }
}
