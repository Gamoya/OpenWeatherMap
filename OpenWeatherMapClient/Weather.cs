using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Weather {
        [JsonPropertyName("id")]
        public int? WeatherConditionCode { get; set; }
        [JsonPropertyName("main")]
        public string Main { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
