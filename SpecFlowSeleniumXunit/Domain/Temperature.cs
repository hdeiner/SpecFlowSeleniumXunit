using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumXunit.Domain
{
    public class Temperature
    {
        private readonly String temperature;
        private readonly String temperatureUnits;

        public Temperature(String temperature, String temperatureUnits)
        {
            this.temperature = temperature;
            this.temperatureUnits = temperatureUnits;
        }

        public String getTemperature()
        {
            return temperature;
        }

        public Boolean isUsingStandardUnits()
        {
            return temperatureUnits.Equals("F");
        }
    }
}
