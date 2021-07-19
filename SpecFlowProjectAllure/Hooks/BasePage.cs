using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectAllure.Hooks
{
    class BasePage
    {
		private int driverWaitTime = 30;
		protected OpenQA.Selenium.Remote.RemoteWebDriver driver;

		public BasePage(ScenarioContext scenarioContext)
		{
			driver = scenarioContext.getDriver();
		}

		public void webClickElement(By ele)
		{
			driver.FindElement(ele).Click();
		}

	}
}
