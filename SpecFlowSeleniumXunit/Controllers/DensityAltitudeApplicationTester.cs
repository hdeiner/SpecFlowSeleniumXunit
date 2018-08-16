using SpecFlowSeleniumXunit.Domain;
using SpecFlowSeleniumXunit.PageObjects;

using System;

namespace SpecFlowSeleniumXunit.Controllers
{
    public class DensityAltitudeApplicationTester
    {
        private readonly String browser;
        private readonly String application;
        private readonly Elevation elevation;
        private readonly Temperature temperature;
        private readonly Altimeter altimeter;
        private readonly DewPoint dewPoint;

        public DensityAltitudeApplicationTester(String browser, String application, Elevation elevation, Temperature temperature, Altimeter altimeter, DewPoint dewPoint)
        {
            this.browser = browser;
            this.application = application;
            this.elevation = elevation;
            this.temperature = temperature;
            this.altimeter = altimeter;
            this.dewPoint = dewPoint;
        }

        public Altitude densityAltitudeResult(String densityAltitudeUnits)
        {
            DensityAltitudeApplicationPageFactory densityAltitudeApplicationPageFactory = new DensityAltitudeApplicationPageFactory(browser, application);
            DensityAltitudeApplicationPage densityAltitudeApplicationPage = densityAltitudeApplicationPageFactory.getVariant();

            densityAltitudeApplicationPage.loadPage();

            densityAltitudeApplicationPage.setElevation(elevation);
            densityAltitudeApplicationPage.setTemperature(temperature);
            densityAltitudeApplicationPage.setAltimeter(altimeter);
            densityAltitudeApplicationPage.setDewPoint(dewPoint);

            Altitude densityAltitude = densityAltitudeApplicationPage.getDensityAltitude(densityAltitudeUnits);

            densityAltitudeApplicationPage.quit();

            return densityAltitude;
        }
    }
}
