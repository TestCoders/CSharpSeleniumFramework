using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using static SeleniumTestFramework.Globals;


namespace SeleniumTestFramework.Interactions
{
    public class SeleniumElement
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public SeleniumElement(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement FindElement(By by, int timeOut = TimeOut)
        {
            return WaitUntil(timeOut).Until(driver => driver.FindElement(by));
        }

        private WebDriverWait WaitUntil(int timeOut = TimeOut)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
        }
    }
}
