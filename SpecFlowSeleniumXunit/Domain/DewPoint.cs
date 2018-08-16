using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumXunit.Domain
{
    public class DewPoint
    {
        private readonly String dewPoint;
        private readonly String dewPointUnits;

        public DewPoint(String dewPoint, String dewPointUnits)
        {
            this.dewPoint = dewPoint;
            this.dewPointUnits = dewPointUnits;
        }

        public String getDewPoint()
        {
            return dewPoint;
        }

        public Boolean isUsingStandardUnits()
        {
            return dewPointUnits.Equals("F");
        }
    }
}
