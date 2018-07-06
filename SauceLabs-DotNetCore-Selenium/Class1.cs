using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SauceLabs_DotNetCore_Selenium
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void SauceLabsTest()
        {
            Uri bsuri = new Uri("http://ondemand.saucelabs.com:80/wd/hub");
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");
            caps.SetCapability(CapabilityType.Version, "60");
            caps.SetCapability(CapabilityType.Platform, "Windows 10");
            caps.SetCapability("username", "");
            caps.SetCapability("accessKey", "");
            caps.SetCapability("name", "testing");
            caps.SetCapability("idleTimeout", "15");
            driver = new RemoteWebDriver(bsuri, caps);

            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
            driver.Quit();
        }
    }
}
