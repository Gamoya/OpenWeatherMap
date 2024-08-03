using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Coordinates {
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
    }
}
