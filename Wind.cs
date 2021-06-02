using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherLibraryJson
{
    public class Wind
    {
        public float Speed { get; }
        public float Degrees { get; }

        public Wind(float speed, float deg)
        {
            Speed = speed;
            Degrees = deg;
        }
    }
}
