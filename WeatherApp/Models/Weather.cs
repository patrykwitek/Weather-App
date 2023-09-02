﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.Models
{
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string customIcon => string.Format(ImageService.GetImageName(icon));
    }
}
