using BrowserStackApp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BrowserStackApp.Steps
{
    [Binding]
    public class OpenAudenSiteSteps
    {
        private IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;
        public OpenAudenSiteSteps()
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
        }


        [Given(@"I am on the Auden Home Page for (.*) and (.*)")]
        public void GivenIAmOnTheAudenHomePageForParallelAndChrome(string profile, string environment)
        {
            _driver = _bsDriver.Init(profile, environment);
            _driver.Navigate().GoToUrl("https://www.google.co.uk/");
        }

        [When(@"I Click On Login")]
        public void WhenIClickOnLogin()
        {
            var q = _driver.FindElement(By.CssSelector("#lst-ib"));
            q.SendKeys("Short term loans");
            q.Submit();
        }
        
        [Then(@"I should see LoginPage")]
        public void ThenIShouldSeeLoginPage()
        {
            var q = _driver.FindElement(By.CssSelector("#lst-ib"));
            Console.WriteLine(q.Text);
        }
    }
}
