using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using static SeleniumTestFramework.Globals;


namespace SeleniumTestFramework.Interactions
{
    public class SeleniumElement
    {
        protected IWebDriver Driver;
        protected WebDriverWait WebDriverWait;

        public SeleniumElement(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement FindElement(By by, int timeOut = TimeOut)
        {
            WaitForDocumentReadyState();
            return Wait(timeOut).Until(driver => driver.FindElement(by));
        }

        public IEnumerable<IWebElement> FindElements(By by, int timeOut = TimeOut)
        {
            WaitForDocumentReadyState();
            return Wait(timeOut).Until(driver => driver.FindElements(by));
        }

        private WebDriverWait Wait(int timeOut = TimeOut)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
        }

        private void WaitForDocumentReadyState()
        {
            var jse = (IJavaScriptExecutor)Driver;

            try
            {
                Wait(5).Until(driver => jse.ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception ex)
            {
                if (ex is WebDriverTimeoutException || ex is TimeoutException)
                {
                    Console.WriteLine("Time out exception during page load. Moving on..");
                    return;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
