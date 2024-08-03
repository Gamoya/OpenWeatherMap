using System;
using System.Runtime.Serialization;

namespace Gamoya.Weather.OpenWeatherMap {
    public class OpenWeatherMapException : Exception {
        public OpenWeatherMapException() : base() { }
        public OpenWeatherMapException(string message) : base(message) { }
        protected OpenWeatherMapException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public OpenWeatherMapException(string message, Exception innerException) : base(message, innerException) { }
    }
}
