using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace learning.steps_files
{
    [Binding]
    public class FeatureSteps
    {
        public IWebDriver driver;
        public ScenarioContext context;
        public FeatureSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Launch the flight booking application")]
        public void GivenLaunchTheFlightBookingApplication()
        {


            //driver.Navigate().GoToUrl("https://rahulshettyacademy.com/seleniumPractise/#/");
            //Thread.Sleep(3000);

            //IList<IWebElement> products = driver.FindElements(By.XPath("//button[text()='ADD TO CART']"));
            //for (int i = 0; i < products.Count; i++)
            //{
            //    String name = products.Contains(i).getText();
            //    if (name.Contains("Cucumber"))
            //    {
            //        driver.FindElements(By.XPath("//button[text()='ADD TO CART']")).Get(i).click();
            //    }
            //}

        }
        
        
        [Given(@"Click on the Login button to make login into application\.")]
        public void GivenClickOnTheLoginButtonToMakeLoginIntoApplication_()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/dropdownsPractise/");
            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("//select[@id='ctl00_mainContent_DropDownListCurrency']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//select[@id='ctl00_mainContent_DropDownListCurrency']/option[4]")).Click();




        }

        [When(@"Enter to valid emailid(.*) and pasword(.*)")]
        public void WhenEnterToValidEmailidAndPasword(string email, string password)
        {
         
        }
        
        [Then(@"Click on the Login button to make login")]
        public void ThenClickOnTheLoginButtonToMakeLogin()
        {
            
        }

        [Then(@"Verift the Title of Home page")]
        public void ThenVeriftTheTitleOfHomePage()
        {



        }

    }

    
}
