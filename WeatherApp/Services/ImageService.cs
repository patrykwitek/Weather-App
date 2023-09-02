using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Helpers;

namespace WeatherApp.Services
{
    public class ImageService
    {
        public static string GetImageName(string symbol)
        {
            if (symbol[2] == ConstantHelper.Day)
            {
                if (symbol == ConstantHelper.SunDaySymbol) return ConstantHelper.Sun;
                else if (symbol == ConstantHelper.SunWithCloudsDaySymbol) return ConstantHelper.SunWithClouds;
                else if (symbol == ConstantHelper.CloudsDaySymbol) return ConstantHelper.Clouds;
                else if (symbol == ConstantHelper.DarkCloudsDaySymbol) return ConstantHelper.DarkClouds;
                else if (symbol == ConstantHelper.CloudsWithRainDaySymbol) return ConstantHelper.CloudsWithRain;
                else if (symbol == ConstantHelper.CloudsWithRainAndSunDaySymbol) return ConstantHelper.CloudsWithRainAndSun;
                else if (symbol == ConstantHelper.ThunderstormDaySymbol) return ConstantHelper.Thunderstorm;
                else if (symbol == ConstantHelper.SnowDaySymbol) return ConstantHelper.Snow;
                else if (symbol == ConstantHelper.FogDaySymbol) return ConstantHelper.Fog;
            }
            else if (symbol[2] == ConstantHelper.Night)
            {
                if (symbol == ConstantHelper.SunNightSymbol) return ConstantHelper.Sun;
                else if (symbol == ConstantHelper.NightcloudNightSymbol) return ConstantHelper.Nightcloud;
                else if (symbol == ConstantHelper.CloudsNightSymbol) return ConstantHelper.Clouds;
                else if (symbol == ConstantHelper.DarkCloudsNightSymbol) return ConstantHelper.DarkClouds;
                else if (symbol == ConstantHelper.CloudsWithRainNightSymbol) return ConstantHelper.CloudsWithRain;
                else if (symbol == ConstantHelper.CloudsWithRainAndMoonNightSymbol) return ConstantHelper.CloudsWithRainAndMoon;
                else if (symbol == ConstantHelper.ThunderstormNightSymbol) return ConstantHelper.Thunderstorm;
                else if (symbol == ConstantHelper.SnowNightSymbol) return ConstantHelper.Snow;
                else if (symbol == ConstantHelper.FogNightSymbol) return ConstantHelper.Fog;
            }
            return ConstantHelper.Sun;
        }
    }
}
