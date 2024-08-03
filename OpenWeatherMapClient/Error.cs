using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class Error {
        [JsonPropertyName("cod")]
        public int? Code { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
