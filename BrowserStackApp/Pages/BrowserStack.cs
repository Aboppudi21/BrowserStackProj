using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BrowserStackApp.Pages
{
    [Binding]
    class BrowserStack
    {
        private BrowserStackDriver bsDriver;
        private string[] tags;

        [BeforeScenario]
        public void BeforeScenario()
        {
            bsDriver = new BrowserStackDriver(ScenarioContext.Current);
            ScenarioContext.Current["bsDriver"] = bsDriver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            bsDriver.Cleanup();
        }
    }
}