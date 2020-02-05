using OpenQA.Selenium;
using static SeleniumTestFramework.Globals;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumButton : SeleniumElement
    {
        public SeleniumButton(IWebDriver driver) : base(driver)
        {
        }

        public void Click(By by, int timeout = TimeOut)
        {
            FindElement(by, timeout).Click();
        }
    }
}
