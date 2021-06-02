using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class MainTemperature
    {
        public float Temperature { get; }
        public float TempereatureFeelsLike { get; }
        public float TemperatureMin { get; }
        public float TemperatureMax { get; }
        public int Pressure { get; }
        public int Humidity { get; }


        public MainTemperature(float temp, float feels_like, float temp_min, float temp_max, int pressure, int humidity)
        {
            Temperature = temp;
            TempereatureFeelsLike = feels_like;
            TemperatureMin = temp_min;
            TemperatureMax = temp_max;
            Pressure = pressure;
            Humidity = humidity;
        }
    }
}
