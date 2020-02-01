using OpenQA.Selenium;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumElement
    {
        protected IWebDriver Driver;

        public SeleniumElement(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
