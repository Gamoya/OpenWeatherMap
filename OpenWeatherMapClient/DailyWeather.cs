using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class DailyWeather {
        [JsonPropertyName("dt")]
        public long? Timestamp { get; set; }
        [JsonPropertyName("temp")]
        public DailyTemperature DailyTemperature { get; set; }
        [JsonPropertyName("pressure")]
        public decimal? Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public decimal? Humidity { get; set; }
        [JsonPropertyName("weather")]
        public List<Weather> WeatherConditions { get; set; }

        public DateTime? DateTime {
            get {
                return Timestamp.HasValue ? (DateTime?)DateTimeOffset.FromUnixTimeSeconds(Timestamp.Value).UtcDateTime : null;
            }
        }
    }
}
