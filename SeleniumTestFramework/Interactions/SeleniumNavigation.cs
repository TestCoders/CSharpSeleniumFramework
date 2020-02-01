using OpenQA.Selenium;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumNavigation
    {
        private IWebDriver _driver;

        public SeleniumNavigation(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
