using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAllure.Hooks
{
    class InitDriver
    {
        RemoteWebDriver driver;
        
        public RemoteWebDriver getDriver()
        {
            if (null == driver)
            {
                driver = new ChromeDriver();
            }
            return driver;

        }

   

    }
}
