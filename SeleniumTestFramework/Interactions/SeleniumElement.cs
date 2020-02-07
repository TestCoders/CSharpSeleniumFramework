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
                //jse.ExecuteScript("document.readyState = 'ready'");
            }
            catch (Exception ex)
            {
                if (ex is WebDriverTimeoutException || ex is TimeoutException)
                {
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
