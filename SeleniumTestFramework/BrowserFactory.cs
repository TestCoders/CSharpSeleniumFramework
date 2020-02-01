using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestFramework.Enum;
using System;
using System.IO;

namespace SeleniumTestFramework
{
    public class BrowserFactory
    {
        public IWebDriver GetWebDriver(Browser browser)
        {
            var driverDir = Directory.GetCurrentDirectory().Replace("Domain", "SeleniumTestFramework").Replace("netcoreapp2.1", "netstandard2.0"); 

            switch (browser)
            {
                case Browser.Chrome:
                    return new ChromeDriver(driverDir);

                case Browser.Firefox:
                    throw new NotImplementedException($"Firefox is not yet supported..");

                case Browser.Ie:
                    throw new NotImplementedException($"Internet Explorer is not yet supported..");

                case Browser.Edge:
                    throw new NotImplementedException($"Edge is not yet supported..");

                case Browser.Safari:
                    throw new NotImplementedException($"Safari is not yet supported..");

                default:
                    throw new ArgumentOutOfRangeException($"Invalid browser receveid! Actual: {browser}");
            }
        } 
    }
}
