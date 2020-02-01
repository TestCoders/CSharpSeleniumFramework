using OpenQA.Selenium;
using SeleniumTestFramework.Enum;
using SeleniumTestFramework.Interactions;

namespace SeleniumTestFramework
{
    public class BaseInteractions
    {
        protected IWebDriver Driver { get; }
        public SeleniumElement Element { get; }
        public SeleniumButton Button { get; }
        public SeleniumIframe Iframe { get; }
        public SeleniumInput Input { get; }
        public SeleniumLabel Label { get; }
        public SeleniumSelect Select { get; }
        public SeleniumNavigation Navigation { get; }

        public BaseInteractions()
        {
            Driver = new BrowserFactory().GetWebDriver(Browser.Chrome);
            Element = new SeleniumElement(Driver);
            Button = new SeleniumButton(Driver);
            Iframe = new SeleniumIframe(Driver);
            Input = new SeleniumInput(Driver);
            Label = new SeleniumLabel(Driver);
            Select = new SeleniumSelect(Driver);
            Navigation = new SeleniumNavigation(Driver);
        }
    }
}
