using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Axe
{
    [TestFixture]
    public class AccessibilityTesting
    {
        public IWebDriver webDriver;
        [SetUp]
        public void ChromeBrowserInitialization()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--start-maximized");       // Start Chrome maximized
            options.AddArgument("--disable-popup-blocking"); // Disable pop-ups
            options.AddArgument("--disable-notifications");
            webDriver = new ChromeDriver(options);
        }

        [Test]
        public void HomePage()
        {

        }
    }
}
