using OpenQA.Selenium;
using System;

namespace SpecFlowSeleniumXunit.PageObjects
{
    public class SeleniumCommonActions
    {
        private IWebDriver webDriver;

        public SeleniumCommonActions(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void SaveScreenshot()
        {
            string fileName = "./" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg";
            Screenshot screenShot = ((ITakesScreenshot)webDriver).GetScreenshot();
            screenShot.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
        }
    }
}
