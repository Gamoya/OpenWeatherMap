using System.Text.Json.Serialization;

#if NET8_0_OR_GREATER

namespace Gamoya.Weather.OpenWeatherMap {
    [JsonSourceGenerationOptions()]
    [JsonSerializable(typeof(CurrentWeatherResponse))]
    [JsonSerializable(typeof(ForecastWeatherResponse))]
    [JsonSerializable(typeof(DailyWeatherResponse))]
    internal partial class SourceGenerationContext : JsonSerializerContext {
    }
}

#endif
