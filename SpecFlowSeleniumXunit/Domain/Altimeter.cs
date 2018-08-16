using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumXunit.Domain
{
    public class Altimeter
    {
        private readonly String altimeter;
        private readonly String altimeterUnits;

        public Altimeter(String altimeter, String altimeterUnits)
        {
            this.altimeter = altimeter;
            this.altimeterUnits = altimeterUnits;
        }
        public String getAltimeter()
        {
            return altimeter;
        }

        public Boolean isUsingStandardUnits()
        {
            return altimeterUnits.Equals("in Hg");
        }
    }
}
