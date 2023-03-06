using System;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = System.IO.File.ReadAllText("appsettings.json");

            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode:");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F.");
        }
    }
}

