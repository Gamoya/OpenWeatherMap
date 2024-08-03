using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Wind {
        [JsonPropertyName("speed")]
        public decimal? Speed { get; set; }
        [JsonPropertyName("deg")]
        public decimal? Direction { get; set; }
        [JsonPropertyName("gust")]
        public decimal? Gust { get; set; }
    }
}
