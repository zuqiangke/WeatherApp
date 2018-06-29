﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class Weather
    {
        // Because label bind to these values, set them to an empty string to
        // ensure that the label appears on all platforms by default
        public string Title { get; set; } = " ";
        public string Temprarture { get; set; } = " ";
        public string Wind { get; set; } = " ";
        public string Humidity { get; set; } = " ";
        public string Visiability { get; set; } = " ";
        public string Sunrise { get; set; } = " ";
        public string Sunset { get; set; } = " ";
    }
}