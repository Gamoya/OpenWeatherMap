namespace Gamoya.Weather.OpenWeatherMap.Example {
    internal class Program {
        static async Task Main(string[] args) {
            var apiKey = Environment.GetEnvironmentVariable("OPEN_WEATHER_MAP_API_KEY");
            var settings = new Settings { Units = Units.Metric, LanguageCode = "en" };

            var latitude = 52.520008m;
            var longitude = 13.404954m;

            using (var openWeatherMapClient = new OpenWeatherMapClient(apiKey, settings)) {
                var currentWeather = await openWeatherMapClient.GetCurrentWeatherAsync(latitude, longitude);
                Console.WriteLine(string.Format("The temperature in Berlin is {0}°C", currentWeather.Main.Temperature));

                var weatherForecast = await openWeatherMapClient.GetForecastWeatherAsync(latitude, longitude);
                foreach (var forecastDay in weatherForecast.Weather) {
                    Console.WriteLine(string.Format("The temperature in Berlin on {0} is {1}°C", forecastDay.DateTime, forecastDay.Main.MaximumTemperature));
                }
            }
        }
    }
}
