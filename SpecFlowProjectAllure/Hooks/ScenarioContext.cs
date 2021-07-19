using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectAllure.Hooks
{
    public class ScenarioContext
	{
        private RemoteWebDriver driver;
		private InitDriver initDriver = new InitDriver();

		public RemoteWebDriver getDriver()
		{
			if (null == driver)
			{
				driver = initDriver.getDriver();
				driver.Manage().Window.Maximize();
			}
			return driver;
		}

		public void quitDriver()
		{
			if (null != driver)
			{
				driver.Quit();
			}
			
		}

	}
}
