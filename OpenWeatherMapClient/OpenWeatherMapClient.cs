using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gamoya.Weather.OpenWeatherMap {
    public class OpenWeatherMapClient : IDisposable {
        private const string _baseUrl = "http://api.openweathermap.org/data/2.5/";

        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        };

        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;

        private readonly string _apiKey;
        private readonly Settings _defaultSettings;

#if NET8_0_OR_GREATER

        static OpenWeatherMapClient() {
            _jsonSerializerOptions.TypeInfoResolver = SourceGenerationContext.Default;
        }

#endif

        public OpenWeatherMapClient(string apiKey) : this(apiKey, null) {
        }

        public OpenWeatherMapClient(string apiKey, Settings defaultSettings) {
            _httpClient = CreateHttpClient();
            _disposeHttpClient = true;
            _apiKey = apiKey;
            _defaultSettings = defaultSettings;
        }

        public OpenWeatherMapClient(string apiKey, Settings defaultSettings, HttpClient httpClient) {
            _httpClient = httpClient;
            _disposeHttpClient = false;
            _apiKey = apiKey;
            _defaultSettings = defaultSettings;
        }

        public static HttpClient CreateHttpClient() {
            var httpClient = new HttpClient {
                BaseAddress = new Uri(_baseUrl)
            };

            return httpClient;
        }

        public void Dispose() {
            if (_disposeHttpClient) {
                _httpClient.Dispose();
            }
        }

        private static async Task<T> ResultAsync<T>(HttpResponseMessage response) {
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) {
                return JsonSerializer.Deserialize<T>(content, _jsonSerializerOptions);
            } else {
                Error error;
                try {
                    error = JsonSerializer.Deserialize<Error>(content, _jsonSerializerOptions);
                } catch {
                    throw new OpenWeatherMapException(content);
                }
                throw new OpenWeatherMapException(error.Message);
            }
        }

        private static string BuildParameters(Settings settings) {
            var paramtersBuilder = new StringBuilder();

            if (settings.Units.HasValue) {
                paramtersBuilder.AppendFormat("&units={0}", GetUnits(settings.Units.Value));
            }
            if (!string.IsNullOrWhiteSpace(settings.LanguageCode)) {
                paramtersBuilder.AppendFormat("&lang={0}", Uri.EscapeDataString(settings.LanguageCode));
            }

            return paramtersBuilder.ToString();
        }

        private static string GetUnits(Units units) {
            switch (units) {
                case Units.Standard:
                    return "standard";
                case Units.Metric:
                    return "metric";
                case Units.Imperial:
                    return "imperial";
            }

            return null;
        }

        public async Task<CurrentWeatherResponse> GetCurrentWeatherAsync(decimal latitude, decimal longitude, Settings settings) {
            using (var message = new HttpRequestMessage(HttpMethod.Get, string.Format("weather?lat={0}&lon={1}&appid={2}{3}", latitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), longitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), _apiKey, BuildParameters(settings)))) {
                using (var response = await _httpClient.SendAsync(message)) {
                    return await ResultAsync<CurrentWeatherResponse>(response);
                }
            }
        }

        public async Task<ForecastWeatherResponse> GetForecastWeatherAsync(decimal latitude, decimal longitude, Settings settings) {
            using (var message = new HttpRequestMessage(HttpMethod.Get, string.Format("forecast?lat={0}&lon={1}&appid={2}{3}", latitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), longitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), _apiKey, BuildParameters(settings)))) {
                using (var response = await _httpClient.SendAsync(message)) {
                    return await ResultAsync<ForecastWeatherResponse>(response);
                }
            }
        }

        public async Task<DailyWeatherResponse> GetDailyForecastWeatherAsync(decimal latitude, decimal longitude, int count, Settings settings) {
            using (var message = new HttpRequestMessage(HttpMethod.Get, string.Format("forecast/daily?lat={0}&lon={1}&cnt={2}&appid={3}{4}", latitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), longitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), count, _apiKey, BuildParameters(settings)))) {
                using (var response = await _httpClient.SendAsync(message)) {
                    return await ResultAsync<DailyWeatherResponse>(response);
                }
            }
        }

        public Task<CurrentWeatherResponse> GetCurrentWeatherAsync(decimal latitude, decimal longitude) {
            return GetCurrentWeatherAsync(latitude, longitude, _defaultSettings);
        }

        public Task<ForecastWeatherResponse> GetForecastWeatherAsync(decimal latitude, decimal longitude) {
            return GetForecastWeatherAsync(latitude, longitude, _defaultSettings);
        }

        public Task<DailyWeatherResponse> GetDailyForecastWeatherAsync(decimal latitude, decimal longitude, int count) {
            return GetDailyForecastWeatherAsync(latitude, longitude, count, _defaultSettings);
        }
    }
}
