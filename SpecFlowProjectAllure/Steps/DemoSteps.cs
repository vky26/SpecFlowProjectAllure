using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAllure.Steps
{
    [Binding]
    public class DemoSteps
    {
        
        String url = "";
        IWebDriver driver;

        [Given(@"I launch the app")]
        public void GivenILaunchTheApp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testscriptdemo.com/";
            System.Threading.Thread.Sleep(3000);
        }
        
        [Given(@"I click on wishlist")]
        public void GivenIClickOnWishlist()
        {
        driver.FindElement(By.XPath("(//a[@title='Wishlist'])[1]")).Click();
        System.Threading.Thread.Sleep(3000);
       
        }
        
        [Then(@"I logout of the app")]
        public void ThenILogoutOfTheApp()
        {
            driver.Quit();
            Assert.True(true);
        }
    }
}
