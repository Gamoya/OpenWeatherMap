using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Precipitation {
        [JsonPropertyName("3h")]
        public decimal? Last3Hours { get; set; }
    }
}
