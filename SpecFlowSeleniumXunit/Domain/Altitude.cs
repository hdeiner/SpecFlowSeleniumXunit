using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumXunit.Domain
{
    public class Altitude
    {
        private readonly String altitude;
        private readonly String altitudeUnits;

        public Altitude(String altitude, String altitudeUnits)
        {
            this.altitude = altitude;
            this.altitudeUnits = altitudeUnits;
        }

        public Boolean isUsingStandardUnits()
        {
            return altitudeUnits.Equals("feet");
        }

        public override String ToString()
        {
            return altitude + " " + altitudeUnits;
        }
    }
}
