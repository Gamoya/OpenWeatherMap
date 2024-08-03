namespace Gamoya.Weather.OpenWeatherMap {
    /// <summary>
    /// weather-condition-codes
    /// </summary>
    /// <remarks>
    /// https://openweathermap.org/weather-conditions
    /// </remarks>
    public static class WeatherConditionCodes {
        public const int ThunderstormWithLightRain = 200;
        public const int ThunderstormWithRain = 201;
        public const int ThunderstormWithHeavyRain = 202;
        public const int LightThunderstorm = 210;
        public const int Thunderstorm = 211;
        public const int HeavyThunderstorm = 212;
        public const int RaggedThunderstorm = 221;
        public const int ThunderstormWithLightDrizzle = 230;
        public const int ThunderstormWithDrizzle = 231;
        public const int ThunderstormWithHeavyDrizzle = 232;

        public const int LightIntensityDrizzle = 300;
        public const int Drizzle = 301;
        public const int HeavyIntensityDrizzle = 302;
        public const int LightIntensityDrizzleRain = 310;
        public const int DrizzleRain = 311;
        public const int HeavyIntensityDrizzleRain = 312;
        public const int ShowerRainAndDrizzle = 313;
        public const int HeavyShowerRainAndDrizzle = 314;
        public const int ShowerDrizzle = 321;

        public const int LightRain = 500;
        public const int ModerateRain = 501;
        public const int HeavyIntensityRain = 502;
        public const int VeryHeavyRain = 503;
        public const int ExtremeRain = 504;
        public const int FreezingRain = 511;
        public const int LightIntensityShowerRain = 520;
        public const int ShowerRain = 521;
        public const int HeavyIntensityShowerRain = 522;
        public const int RaggedShowerRain = 531;

        public const int LightSnow = 600;
        public const int Snow = 601;
        public const int HeavySnow = 602;
        public const int Sleet = 611;
        public const int LightShowerSleet = 612;
        public const int ShowerSleet = 613;
        public const int LightRainAndSnow = 615;
        public const int RainAndSnow = 616;
        public const int LightShowerSnow = 620;
        public const int ShowerSnow = 621;
        public const int HeavyShowerSnow = 622;

        public const int Mist = 701;
        public const int Smoke = 711;
        public const int Haze = 721;
        public const int SandDustWhirls = 731;
        public const int Fog = 741;
        public const int Sand = 751;
        public const int Dust = 761;
        public const int VolcanicAsh = 762;
        public const int Squalls = 771;
        public const int Tornado = 781;

        public const int ClearSky = 800;

        public const int FewClouds = 801;
        public const int ScatteredClouds = 802;
        public const int BrokenClouds = 803;
        public const int OvercastClouds = 804;
    }
}
