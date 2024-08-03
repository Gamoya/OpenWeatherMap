using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class CurrentWeatherResponse {
        [JsonPropertyName("id")]
        public long? CityId { get; set; }
        [JsonPropertyName("name")]
        public string CityName { get; set; }
        [JsonPropertyName("dt")]
        public long? Timestamp { get; set; }
        [JsonPropertyName("timezone")]
        public long? TimeZone { get; set; }
        [JsonPropertyName("coord")]
        public Coordinates Coordinates { get; set; }
        [JsonPropertyName("sys")]
        public WeatherLocation WeatherLocation { get; set; }
        [JsonPropertyName("base")]
        public string Base { get; set; }
        [JsonPropertyName("main")]
        public Main Main { get; set; }
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
        [JsonPropertyName("rain")]
        public Precipitation Rain { get; set; }
        [JsonPropertyName("snow")]
        public Precipitation Snow { get; set; }
        [JsonPropertyName("clouds")]
        public Clouds Clouds { get; set; }
        [JsonPropertyName("weather")]
        public List<Weather> WeatherConditions { get; set; }
        [JsonPropertyName("visibility")]
        public decimal? Visibility { get; set; }
        [JsonPropertyName("cod")]
        public long? Code { get; set; }

        public DateTime? DateTime {
            get {
                return Timestamp.HasValue ? (DateTime?)DateTimeOffset.FromUnixTimeSeconds(Timestamp.Value).UtcDateTime : null;
            }
        }
    }
}
