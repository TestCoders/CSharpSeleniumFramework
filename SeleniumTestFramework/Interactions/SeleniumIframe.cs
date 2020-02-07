using OpenQA.Selenium;
using System;

namespace SeleniumTestFramework.Interactions
{
    public class SeleniumIframe : SeleniumElement
    {
        public SeleniumIframe(IWebDriver driver) : base(driver)
        {
        }

        public void SwitchToIframe(By by, int timeOut = Globals.TimeOut)
        {
            throw new NotImplementedException("Iframe methods are not yet implemented!");
        }

        public void SwitchToDefaultContent()
        {
            throw new NotImplementedException("Iframe methods are not yet implemented!");
        }
    }
}
