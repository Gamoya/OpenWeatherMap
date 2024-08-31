# OpenWeatherMap
An aot compatible .NET client for OpenWeatherMap (https://openweathermap.org/)

[![NuGet](https://img.shields.io/nuget/v/Gamoya.Weather.OpenWeatherMap)](https://www.nuget.org/packages/Gamoya.Weather.OpenWeatherMap)
[![GitHub](https://img.shields.io/github/license/Gamoya/OpenWeatherMap)](https://github.com/Gamoya/OpenWeatherMap/blob/main/LICENSE)

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
