using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace learning.Hooks
{
    [Binding]
    public class Hooks1
    {
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private readonly IObjectContainer iob;
        public IWebDriver driver;
            
       
        public Hooks1(IObjectContainer iob)
        {
            this.iob = iob;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            

            iob.RegisterInstanceAs<IWebDriver>(driver);
            
            
           
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}
