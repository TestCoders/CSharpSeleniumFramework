using OpenQA.Selenium;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumInput : SeleniumElement
    {
        public SeleniumInput(IWebDriver driver) : base(driver)
        {
        }

        public void Clear(By by, int timeOut = Globals.TimeOut)
        {
            FindElement(by, timeOut).Clear();
        }

        public void EnterText(By by, string text, int timeOut = Globals.TimeOut)
        {
            FindElement(by, timeOut).SendKeys(text);
        }
    }
}
