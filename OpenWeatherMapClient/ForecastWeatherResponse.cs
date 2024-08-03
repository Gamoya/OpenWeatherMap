using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class ForecastWeatherResponse {
        [JsonPropertyName("city")]
        public City City { get; set; }
        [JsonPropertyName("cnt")]
        public int Count { get; set; }
        [JsonPropertyName("list")]
        public List<ForecastWeather> Weather { get; set; }
    }
}
