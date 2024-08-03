using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class WeatherLocation {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        [JsonPropertyName("type")]
        public long? Type { get; set; }
        [JsonPropertyName("country")]
        public string CountryCode { get; set; }
        [JsonPropertyName("sunrise")]
        public long? Sunrise { get; set; }
        [JsonPropertyName("sunset")]
        public long? Sunset { get; set; }
    }
}
