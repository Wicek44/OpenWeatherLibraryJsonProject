using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class Coordinates
    {
        public float Longitude { get; }
        public float Latitude { get; }

        public Coordinates(float lon, float lat)
        {
            Longitude = lon;
            Latitude = lat;
        }

    }
}
