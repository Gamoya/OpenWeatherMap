using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Clouds {
        [JsonPropertyName("all")]
        public decimal? CloudCover { get; set; }
    }
}
