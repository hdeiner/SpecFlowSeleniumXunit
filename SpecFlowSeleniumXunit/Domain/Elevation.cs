using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumXunit.Domain
{
    public class Elevation
    {
        private readonly String elevation;
        private readonly String elevationUnits;

        public Elevation(String elevation, String elevationUnits)
        {
            this.elevation = elevation;
            this.elevationUnits = elevationUnits;
        }

        public String getElevation()
        {
            return elevation;
        }

        public Boolean isUsingStandardUnits()
        {
            return elevationUnits.Equals("feet");
        }
    }
}
