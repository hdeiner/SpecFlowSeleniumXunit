using SpecFlowSeleniumXunit.Domain;

using System;

namespace SpecFlowSeleniumXunit.PageObjects
{
    interface DensityAltitudeApplicationPage
    {
        void loadPage();
        void setElevation(Elevation elevation);
        void setTemperature(Temperature temperature);
        void setAltimeter(Altimeter altimeter);
        void setDewPoint(DewPoint dewPoint);
        Altitude getDensityAltitude(String densityAltitudeUnits);
        void quit();
    }
}
