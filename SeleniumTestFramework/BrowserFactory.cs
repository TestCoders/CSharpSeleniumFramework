using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestFramework.Enum;
using System;

namespace SeleniumTestFramework
{
    public class BrowserFactory
    {
        public IWebDriver GetWebDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver();

                default:
                    throw new NotImplementedException($"Invalid browser receveid! Actual: {browser}. Only Chrome is supported");
            }
        } 
    }
}
