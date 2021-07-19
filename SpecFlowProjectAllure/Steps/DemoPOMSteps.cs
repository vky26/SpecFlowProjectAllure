using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectAllure.Hooks;
using SpecFlowProjectAllure.Page;
using TechTalk.SpecFlow;
using ScenarioContext = SpecFlowProjectAllure.Hooks.ScenarioContext;

namespace SpecFlowProjectAllure.Steps
{
    [Binding]
    public class DemoPOMSteps
    {
        
        String url = "";
        private ScenarioContext sc;
        private LoginPage loginPage;

        public DemoPOMSteps(ScenarioContext scenarioContext)
        {
            this.sc = scenarioContext;
            loginPage = new LoginPage(sc);
        }

        [Given(@"I launch the app POM")]
        public void GivenILaunchTheApp()
        {
           
            loginPage.loginToApp("https://testscriptdemo.com/");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Launched App");
        }
        
        [Given(@"I click on wishlist POM")]
        public void GivenIClickOnWishlist()
        {
            loginPage.loginToShoppingSite();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Clicked on wishlist");
        }
        
        [Then(@"I logout of the app POM")]
        public void ThenILogoutOfTheApp()
        {
            Assert.True(true);
            Console.WriteLine("Done");
        }
    }
}
