using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class ForecastWeather {
        [JsonPropertyName("dt")]
        public long? Timestamp { get; set; }
        [JsonPropertyName("main")]
        public Main Main { get; set; }
        [JsonPropertyName("weather")]
        public List<Weather> WeatherConditions { get; set; }

        public DateTime? DateTime {
            get {
                return Timestamp.HasValue ? (DateTime?)DateTimeOffset.FromUnixTimeSeconds(Timestamp.Value).UtcDateTime : null;
            }
        }
    }
}
