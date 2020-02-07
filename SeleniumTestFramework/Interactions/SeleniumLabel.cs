using OpenQA.Selenium;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumLabel : SeleniumElement
    {
        public SeleniumLabel(IWebDriver driver) : base(driver)
        {
        }

        public string GetText(By by, int timeOut = Globals.TimeOut)
        {
            return FindElement(by, timeOut).Text;
        }
    }
}
