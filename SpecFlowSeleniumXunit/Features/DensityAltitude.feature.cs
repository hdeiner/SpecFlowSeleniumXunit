﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowSeleniumXunit.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Density Altitude", Description=@"  On June 19 and 20, 2017, many flights were cancelled at Arizona's Phoenix Sky Harbor airport
  because it was ""too hot.""  Really?  The engineering reason has to do with the fact that the amount
  of lift generated by a wing is related to the air that it flies in.  When the air becomes ""thin""
  because of heat and humidity (water vapor is less dense than air: that's why clouds tend to float
  above us), they produce less lift, and require higher speeds through the air to produce the lift
  needed to allow the airplanes to take off.  Higher speeds require longer runways, and at a certain
  point, the heat is just too high to have enough safety on any particular runway to allow a safe depature.

  With Global Warming becoming all too real, pliots need to keep their eye on the density altitude (a measure
  of what the heat and humidity would translate into for ""standard"" atmospheric conditions) as they evaluate
  how much runway is needed for a safe takeoff and landing.  If you're interested in the details of how
  density altitude is calculated, take a look at https://en.wikipedia.org/wiki/Density_altitude.

  There are many online resources that pilots can use to calculate density altitude.  We'd like to test them!", SourceFile="Features\\DensityAltitude.feature", SourceLine=0)]
    public partial class DensityAltitudeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DensityAltitude.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Density Altitude", @"  On June 19 and 20, 2017, many flights were cancelled at Arizona's Phoenix Sky Harbor airport
  because it was ""too hot.""  Really?  The engineering reason has to do with the fact that the amount
  of lift generated by a wing is related to the air that it flies in.  When the air becomes ""thin""
  because of heat and humidity (water vapor is less dense than air: that's why clouds tend to float
  above us), they produce less lift, and require higher speeds through the air to produce the lift
  needed to allow the airplanes to take off.  Higher speeds require longer runways, and at a certain
  point, the heat is just too high to have enough safety on any particular runway to allow a safe depature.

  With Global Warming becoming all too real, pliots need to keep their eye on the density altitude (a measure
  of what the heat and humidity would translate into for ""standard"" atmospheric conditions) as they evaluate
  how much runway is needed for a safe takeoff and landing.  If you're interested in the details of how
  density altitude is calculated, take a look at https://en.wikipedia.org/wiki/Density_altitude.

  There are many online resources that pilots can use to calculate density altitude.  We'd like to test them!", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void DensityAltitudeChecking(string browser, string application, string elevation, string elevationUnits, string temperature, string temperatureUnits, string altimeter, string altimeterUnits, string dewPoint, string dewPointUnits, string densityAltitude, string densityAltitudeUnits, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Density altitude checking", exampleTags);
#line 18
  this.ScenarioSetup(scenarioInfo);
#line 19
    testRunner.When(string.Format("I use a \"{0}\" browser", browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And(string.Format("the \"{0}\" application", application), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And(string.Format("the elevation is \"{0}\" \"{1}\"", elevation, elevationUnits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.And(string.Format("the temperature is \"{0}\" \"{1}\"", temperature, temperatureUnits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.And(string.Format("the altimeter is \"{0}\" \"{1}\"", altimeter, altimeterUnits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And(string.Format("the dew point is \"{0}\" \"{1}\"", dewPoint, dewPointUnits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.Then(string.Format("the density altitude should be \"{0}\" \"{1}\"", densityAltitude, densityAltitudeUnits), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 0", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant0()
        {
#line 18
  this.DensityAltitudeChecking("firefox", "Pilot Friend", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 1", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant1()
        {
#line 18
  this.DensityAltitudeChecking("firefox", "Shelquist Engineering", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 2", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant2()
        {
#line 18
  this.DensityAltitudeChecking("chrome", "Pilot Friend", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 3", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant3()
        {
#line 18
  this.DensityAltitudeChecking("chrome", "Shelquist Engineering", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 4", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant4()
        {
#line 18
  this.DensityAltitudeChecking("chromeHeadless", "Pilot Friend", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 5", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant5()
        {
#line 18
  this.DensityAltitudeChecking("chromeHeadless", "Shelquist Engineering", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 6", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant6()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Pilot Friend", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 7", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant7()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Shelquist Engineering", "182", "feet", "80", "F", "30.02", "in Hg", "70", "F", "1779", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 8", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant8()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Pilot Friend", "182", "feet", "60", "F", "29.95", "in Hg", "40", "F", "365", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 9", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant9()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Shelquist Engineering", "182", "feet", "60", "F", "29.95", "in Hg", "40", "F", "365", "feet", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 10", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant10()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Pilot Friend", "30", "meters", "25", "C", "1000", "hPa", "20", "C", "618", "meters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Density altitude checking, Variant 11", SourceLine=28)]
        public virtual void DensityAltitudeChecking_Variant11()
        {
#line 18
  this.DensityAltitudeChecking("edge", "Shelquist Engineering", "30", "meters", "25", "C", "1000", "hPa", "20", "C", "618", "meters", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
