using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherMap
{
    public class Weather
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;
        }
    }
}

