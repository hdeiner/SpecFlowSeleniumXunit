using System;

namespace SpecFlowSeleniumXunit.PageObjects
{
    class DensityAltitudeApplicationPageFactory
    {
        private DensityAltitudeApplicationPage densityAltitudeApplicationPage = null;

        public DensityAltitudeApplicationPageFactory(String browser, String application)
        {
            if (browser.Equals("firefox") && application.Equals("Pilot Friend"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Firefox_PilotFriend();
            }
            if (browser.Equals("firefox") && application.Equals("Shelquist Engineering"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Firefox_ShelquistEngineering();
            }
            if (browser.Equals("chrome") && application.Equals("Pilot Friend"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Chrome_PilotFriend();
            }
            if (browser.Equals("chrome") && application.Equals("Shelquist Engineering"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Chrome_ShelquistEngineering();
            }
            if (browser.Equals("chromeHeadless") && application.Equals("Pilot Friend"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_ChromeHeadless_PilotFriend();
            }
            if (browser.Equals("chromeHeadless") && application.Equals("Shelquist Engineering"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_ChromeHeadless_ShelquistEngineering();
            }
            if (browser.Equals("internet explorer") && application.Equals("Pilot Friend"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_InternetExplorer_PilotFriend();
            }
            if (browser.Equals("internet explorer") && application.Equals("Shelquist Engineering"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_InternetExplorer_ShelquistEngineering();
            }
            if (browser.Equals("edge") && application.Equals("Pilot Friend"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Edge_PilotFriend();
            }
            if (browser.Equals("edge") && application.Equals("Shelquist Engineering"))
            {
                densityAltitudeApplicationPage = new DensityAltitudeApplicationPage_Edge_ShelquistEngineering();
            }
        }

        public DensityAltitudeApplicationPage getVariant()
        {
            return densityAltitudeApplicationPage;
        }
    }
}
