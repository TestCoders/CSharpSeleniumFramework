using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumSelect : SeleniumElement
    {
        public SeleniumSelect(IWebDriver driver) : base(driver)
        {
        }

        public void SelectByInput(By by, string optionText, int timeOut = Globals.TimeOut)
        {
            new SelectElement(FindElement(by, timeOut)).SelectByText(optionText);
        }

        public void SelectByIndex(By by, int index, int timeOut = Globals.TimeOut)
        {
            new SelectElement(FindElement(by, timeOut)).SelectByIndex(index);
        }
    }
}
