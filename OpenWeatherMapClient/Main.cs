using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Main {
        [JsonPropertyName("temp")]
        public decimal? Temperature { get; set; }
        [JsonPropertyName("feels_like")]
        public decimal? FeelsLike { get; set; }
        [JsonPropertyName("humidity")]
        public decimal? Humidity { get; set; }
        [JsonPropertyName("pressure")]
        public decimal? Pressure { get; set; }
        [JsonPropertyName("sea_level")]
        public decimal? SeaLevel { get; set; }
        [JsonPropertyName("grnd_level")]
        public decimal? GroundLevel { get; set; }
        [JsonPropertyName("temp_min")]
        public decimal? MinimumTemperature { get; set; }
        [JsonPropertyName("temp_max")]
        public decimal? MaximumTemperature { get; set; }
    }
}
