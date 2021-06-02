using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class Country
    {
        public string CountryInfo { get; }
        public int Sunrise { get; }
        public int Sunset { get; }

        public Country(string country, int sunrise, int sunset)
        {
            CountryInfo = country;
            Sunrise = sunrise;
            Sunset = sunset;
        }
    }
}
