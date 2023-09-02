using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Helpers
{
    public static class ConstantHelper
    {
        public const string CelciusDegrees = "°C";
        public const string Percent = "%";
        public const string KilometersPerHour = "km/h";
        public const string FormatFilePNG = ".png";

        public const string CityPopupAccept = "Search";
        public const string CityPopupCancel = "Cancel";
        public const string CityPopupContent = "Search weather by city";

        public const char Day = 'd';
        public const char Night = 'n';
        public const string Sun = "sun";
        public const string SunWithClouds = "sunwithclouds";
        public const string Clouds = "clouds";
        public const string DarkClouds = "darkclouds";
        public const string CloudsWithRain = "cloudswithrain";
        public const string CloudsWithRainAndSun = "cloudswithrainandsun";
        public const string CloudsWithRainAndMoon = "cloudswithrainandmoon";
        public const string Thunderstorm = "thunderstorm";
        public const string Snow = "snow";
        public const string Fog = "fog";
        public const string Nightcloud = "nightcloud";

        public const string SunDaySymbol = "01d";
        public const string SunWithCloudsDaySymbol = "02d";
        public const string CloudsDaySymbol = "03d";
        public const string DarkCloudsDaySymbol = "04d";
        public const string CloudsWithRainDaySymbol = "09d";
        public const string CloudsWithRainAndSunDaySymbol = "10d";
        public const string ThunderstormDaySymbol = "11d";
        public const string SnowDaySymbol = "13d";
        public const string FogDaySymbol = "50d";

        public const string SunNightSymbol = "01n";
        public const string NightcloudNightSymbol = "02n";
        public const string CloudsNightSymbol = "03n";
        public const string DarkCloudsNightSymbol = "04n";
        public const string CloudsWithRainNightSymbol = "09n";
        public const string CloudsWithRainAndMoonNightSymbol = "10n";
        public const string ThunderstormNightSymbol = "11n";
        public const string SnowNightSymbol = "13n";
        public const string FogNightSymbol = "50n";
    }
}
