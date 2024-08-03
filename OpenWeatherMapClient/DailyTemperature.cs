using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class DailyTemperature {
        [JsonPropertyName("day")]
        public decimal? Day { get; set; }
        [JsonPropertyName("min")]
        public decimal? Minimum { get; set; }
        [JsonPropertyName("max")]
        public decimal? Maximum { get; set; }
        [JsonPropertyName("night")]
        public decimal? Night { get; set; }
        [JsonPropertyName("eve")]
        public decimal? Evening { get; set; }
        [JsonPropertyName("morn")]
        public decimal? Morning { get; set; }
    }
}
