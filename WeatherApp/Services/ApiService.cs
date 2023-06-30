using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=f86a285788593c9985c95ff359a9dfad", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCityName(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=f86a285788593c9985c95ff359a9dfad", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static string GetImageName(string symbol)
        {
            if (symbol[2] == 'd')
            {
                if (symbol == "01d") return "sun";
                else if (symbol == "02d") return "sunwithclouds";
                else if (symbol == "03d") return "clouds";
                else if (symbol == "04d") return "darkclouds";
                else if (symbol == "09d") return "cloudswithrain";
                else if (symbol == "10d") return "cloudswithrainandsun";
                else if (symbol == "11d") return "thunderstorm";
                else if (symbol == "13d") return "snow";
                else if (symbol == "50d") return "fog";
            }
            else if (symbol[2] == 'n')
            {
                if (symbol == "01n") return "sun";
                else if (symbol == "02n") return "nightcloud";
                else if (symbol == "03n") return "clouds";
                else if (symbol == "04n") return "darkclouds";
                else if (symbol == "09n") return "cloudswithrain";
                else if (symbol == "10n") return "cloudswithrainandmoon";
                else if (symbol == "11n") return "thunderstorm";
                else if (symbol == "13n") return "snow";
                else if (symbol == "50n") return "fog";
            }
            return "sun";
        }
    }
}
