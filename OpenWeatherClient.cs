using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class OpenWeatherClient
    {
        public string ApiKey { get; private set; }
        private WebClient webClient = new WebClient();

        public OpenWeatherClient(string argApiKey)
        {
            ApiKey = argApiKey;
        }


        public WeatherInfoData GetWeatherInfo(string cityName)
        {
            var rawWebData = webClient.DownloadData($"http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&mode=json&units=metric&appid=" + ApiKey);
            var stringWebData = System.Text.Encoding.UTF8.GetString(rawWebData);

            WeatherInfoData weatherInfoData = JsonConvert.DeserializeObject<WeatherInfoData>(stringWebData);

            return weatherInfoData;
        }

        public async Task<WeatherInfoData> GetWeatherInfoAsync(string cityName)
        {
            var rawWebData = await webClient.DownloadDataTaskAsync($"http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&mode=json&units=metric&appid=" + ApiKey);
            var stringWebData = System.Text.Encoding.UTF8.GetString(rawWebData);

            WeatherInfoData weatherInfoData = JsonConvert.DeserializeObject<WeatherInfoData>(stringWebData);

            return weatherInfoData;
        }
    }
}
