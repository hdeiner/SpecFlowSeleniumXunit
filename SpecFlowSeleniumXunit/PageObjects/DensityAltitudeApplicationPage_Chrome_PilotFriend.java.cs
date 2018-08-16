using SpecFlowSeleniumXunit.Domain;

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using TechTalk.SpecFlow;
using System.Collections.ObjectModel;
using Xunit;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowSeleniumXunit.PageObjects
{
    class DensityAltitudeApplicationPage_Chrome_PilotFriend : IDisposable, DensityAltitudeApplicationPage
    {
        private IWebDriver webDriver = null;
        private WebDriverWait webDriverWait = null;
        private string baseURL = "http://www.pilotfriend.com/flightplanning/flight%20planning/calculators/density_altitude_calc.htm";

        public DensityAltitudeApplicationPage_Chrome_PilotFriend()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"bin/debug/chromedriver.exe");
            webDriver = new ChromeDriver();
            webDriverWait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 10));
        }
        public void loadPage()
        {
            webDriver.Navigate().GoToUrl(this.baseURL);
            webDriverWait.Until(webDriver => webDriver.FindElement(By.Name("elevation")).Displayed);
        }

        public void setElevation(Elevation elevation)
        {
            webDriver.FindElement(By.Name("elevation")).SendKeys(elevation.getElevation());
            if (elevation.isUsingStandardUnits())
            {
                webDriver.FindElements(By.Name("in_elev"))[0].Click();
            }
            else
            {
                webDriver.FindElements(By.Name("in_elev"))[1].Click();
            }
        }

        public void setTemperature(Temperature temperature)
        {
            webDriver.FindElement(By.Name("temperature")).SendKeys(temperature.getTemperature());
            if (temperature.isUsingStandardUnits())
            {
                webDriver.FindElements(By.Name("in_temp"))[0].Click();
            }
            else
            {
                webDriver.FindElements(By.Name("in_temp"))[1].Click();
            }
        }

        public void setAltimeter(Altimeter altimeter)
        {
            webDriver.FindElement(By.Name("altset")).SendKeys(altimeter.getAltimeter());
            if (altimeter.isUsingStandardUnits())
            {
                webDriver.FindElements(By.Name("in_alt_set"))[0].Click();
            }
            else
            {
                webDriver.FindElements(By.Name("in_alt_set"))[1].Click();
            }
        }

        public void setDewPoint(DewPoint dewPoint)
        {
            webDriver.FindElement(By.Name("dewpoint")).SendKeys(dewPoint.getDewPoint());
            if (dewPoint.isUsingStandardUnits())
            {
                webDriver.FindElements(By.Name("in_dp"))[0].Click();
            }
            else
            {
                webDriver.FindElements(By.Name("in_dp"))[1].Click();
            }
        }

        public Altitude getDensityAltitude(String densityAltitudeUnits)
        {
            Altitude densityAltitude = new Altitude("", densityAltitudeUnits);
            webDriver.FindElement(By.Name("e_calculate")).Click();
            webDriverWait.Until(webDriver => webDriver.FindElement(By.Name("densaltz")).GetAttribute("value").Length != 0);

            if (densityAltitude.isUsingStandardUnits())
            {
                densityAltitude = new Altitude(webDriver.FindElement(By.Name("densaltz")).GetAttribute("value"), densityAltitudeUnits);
            }
            else
            {
                densityAltitude = new Altitude(webDriver.FindElement(By.Name("densaltzm")).GetAttribute("value"), densityAltitudeUnits);
            }
            SaveScreenshot();
            return densityAltitude;
        }

        public void quit()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            webDriver.Close();
            webDriver.Dispose();
        }

        private void SaveScreenshot()
        {
            string fileName = "./" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg";
            Screenshot screenShot = ((ITakesScreenshot)webDriver).GetScreenshot();
            screenShot.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
        }
    }
}
