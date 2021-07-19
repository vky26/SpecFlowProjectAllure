using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using ScenarioContext = SpecFlowProjectAllure.Hooks.ScenarioContext;

namespace SpecFlowProjectAllure.Page
{
    class LoginPage
    {
        private ScenarioContext sc;

        [FindsBy(How = How.XPath, Using = "(//a[@title='Wishlist'])[1]")]
        private readonly IWebElement wishList;

        public LoginPage(ScenarioContext scenarioContext)
        {
            sc = scenarioContext;
            PageFactory.InitElements(sc.getDriver(), this);
        }


        public void loginToApp(String url)
        {
            sc.getDriver().Url= url;
        }

        public void loginToShoppingSite()
        {
            //sc.getDriver().FindElementByXPath("(//a[@title='Wishlist'])[1]").Click();
            wishList.Click();
        }
    }
}
