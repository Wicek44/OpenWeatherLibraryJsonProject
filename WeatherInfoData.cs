using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class WeatherInfoData
    {
        public Coordinates Coordinates { get; }
        public List<Weather> Weather { get; }
        public MainTemperature MainTemperature { get; }
        public int Visibility { get; }
        public Wind Wind { get; }
        public int DayTime { get; }
        public Country CountryInfo { get; }

        public int Timezone { get; }
        public int ID { get; }
        public string NameOfCity { get; }


        public WeatherInfoData(Coordinates coord, List<Weather> weather, MainTemperature main, int visibility, Wind wind, int dt, Country sys, int timezone, int id, string name)
        {
            Coordinates = coord;
            Weather = weather;
            MainTemperature = main;
            Visibility = visibility;
            Wind = wind;
            DayTime = dt;
            CountryInfo = sys;
            Timezone = timezone;
            ID = id;
            NameOfCity = name;
        }

    }
}
