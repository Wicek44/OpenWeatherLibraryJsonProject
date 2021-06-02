using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class Weather
    {
        public int ID { get; } 
        public string Name { get; }
        public string Description { get; }
        public string Icon { get; }


        public Weather(int id, string main, string description, string icon)
        {
            ID = id;
            Name = main;
            Description = description;
            Icon = icon; 
        }
    }
}
