using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class City {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("country")]
        public string CountryCode { get; set; }
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
    }
}
