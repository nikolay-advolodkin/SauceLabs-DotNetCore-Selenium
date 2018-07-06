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
        public void Test1()
        {
            Uri bsuri = new Uri("http://ondemand.saucelabs.com:80/wd/hub");
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");
            caps.SetCapability(CapabilityType.Version, "60");
            caps.SetCapability(CapabilityType.Platform, "Windows 10");
            caps.SetCapability("username", "nikolay-a");
            caps.SetCapability("accessKey", "0fd366b1-548f-4ef4-8143-4746100fdf96");
            caps.SetCapability("name", "testing");
            caps.SetCapability("idleTimeout", "15");
            driver = new RemoteWebDriver(bsuri, caps);

            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
            driver.Quit();
        }
    }
}
