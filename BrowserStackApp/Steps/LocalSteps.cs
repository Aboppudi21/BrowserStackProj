using System;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using BrowserStackApp.Pages;

namespace SpecFlow_BrowserStack
{
    [Binding]
    public class LocalSteps
    {
        private IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public LocalSteps()
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
        }

        [Given(@"I opened health check for (.*) and (.*)")]
        public void GivenIOpenedHealthCheck(string profile, string environment)
        {
            _driver = _bsDriver.Init(profile, environment);
            _driver.Navigate().GoToUrl("https://www.google.co.uk/");
        }

        [Then(@"I should see '(.*)'")]
        public void ThenIShouldSee()
        {
            var q = _driver.FindElement(By.CssSelector("#lst-ib"));
            q.SendKeys("Short term loans");
            q.Submit();
            var q1 = _driver.FindElement(By.CssSelector("#lst-ib"));
            Console.WriteLine(q1.Text);
        }
    }
}
