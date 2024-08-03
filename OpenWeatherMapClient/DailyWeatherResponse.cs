using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class DailyWeatherResponse {
        [JsonPropertyName("city")]
        public City City { get; set; }
        [JsonPropertyName("cnt")]
        public int Count { get; set; }
        [JsonPropertyName("list")]
        public List<DailyWeather> Weather { get; set; }
    }
}
