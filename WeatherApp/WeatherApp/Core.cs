using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Core
    {
        public static async Task<Weather> GetWeather (string zipCode)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "7c66ccb0aabab45eae6d5c41003a3a75";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + ",us&appid=" + key + "&units=imperial";
            dynamic resoluts = await DataService.getDataFromService(queryString).ConfigureAwait(false);
            if (resoluts["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)resoluts["name"];
                weather.Temprarture = (string)resoluts["main"]["temp"] + " F";
                weather.Wind = (string)resoluts["wind"]["speed"] + " mph";
                weather.Humidity = (string)resoluts["main"]["humidity"] + " %";
                weather.Visiability = (string)resoluts["weather"][0]["main"];
                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)resoluts["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)resoluts["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
