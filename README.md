# OpenWeatherMap
A .NET client for OpenWeatherMap

## Prerequisites
Get API-Key from https://openweathermap.org/

## Usage

```C#
string apiKey = "{your apiKey}";
var settings = new Gamoya.Weather.OpenWeatherMap.Settings { Units = Units.Metric, LanguageCode = "en" };

decimal latitude = 52.520008m;
decimal longitude = 13.404954m;

using (var openWeatherMapClient = new Gamoya.Weather.OpenWeatherMap.OpenWeatherMapClient(apiKey, settings)) {
    var currentWeather = await GetCurrentWeatherAsync(latitude, longitude);
    var forecastWeather = await GetForecastWeatherAsync(latitude, longitude);
}
```
