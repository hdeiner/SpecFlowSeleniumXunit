using SpecFlowSeleniumXunit.Domain;
using SpecFlowSeleniumXunit.Controllers;

using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowSeleniumXunit.StepDefs
{
    [Binding]
    public sealed class DensityAltitudeStepDefs
    {
        private String browser;
        private String application;
        private Elevation elevation;
        private Temperature temperature;
        private Altimeter altimeter;
        private DewPoint dewPoint;

        [When(@"I use a ""(.*)"" browser")]
        public void WhenIUseABrowser(String browser)
        {
            this.browser = browser;
        }

        [When(@"the ""(.*)"" application")]
        public void WhenTheApplication(String application)
        {
            this.application = application;
        }

        [When(@"the elevation is ""(.*)"" ""(.*)""")]
        public void WhenTheElevationIs(String elevation, String elevationUnits)
        {
            this.elevation = new Elevation(elevation, elevationUnits);
        }

        [When(@"the temperature is ""(.*)"" ""(.*)""")]
        public void WhenTheTemperatureIs(String temperature, String temperatureUnits)
        {
            this.temperature = new Temperature(temperature, temperatureUnits);
        }

        [When(@"the altimeter is ""(.*)"" ""(.*)""")]
        public void WhenTheAltimeterIs(String altimeter, String altimeterUnits)
        {
            this.altimeter = new Altimeter(altimeter, altimeterUnits);
        }

        [When(@"the dew point is ""(.*)"" ""(.*)""")]
        public void WhenTheDewPointIs(String dewPoint, String dewPointUnits)
        {
            this.dewPoint = new DewPoint(dewPoint, dewPointUnits);
        }

        [Then(@"the density altitude should be ""(.*)"" ""(.*)""")]
        public void ThenTheDensityAltitudeShouldBe(String densityAltitude, String densityAltitudeUnits)
        {
            DensityAltitudeApplicationTester densityAltitudeApplicationTester = new DensityAltitudeApplicationTester(browser, application, elevation, temperature, altimeter, dewPoint);
            Altitude densityAltitudeResult = densityAltitudeApplicationTester.densityAltitudeResult(densityAltitudeUnits);
            Altitude densityAltitudeExpected = new Altitude(densityAltitude, densityAltitudeUnits);
            Assert.Equal(densityAltitudeExpected.ToString(), densityAltitudeResult.ToString());
        }
    }
}
