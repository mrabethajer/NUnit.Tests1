// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        private IWebElement element;
      // public WiniumDriver driver;
        //private DesktopOptions option;

        [Test]
        public void TestMethod()
        {
            var option = new DesktopOptions
            {
                ApplicationPath = @"C:\Windows\System32\calc.exe"
            };
            Thread.Sleep(2000);
            var driver = new WiniumDriver(new Uri("http://localhost:9999"), option);
            Thread.Sleep(2000);
            Assert.IsNotNull(driver);
            // TODO: Add your test code here
            Thread.Sleep(1450);
            driver.FindElement(By.Name("Sept")).Click();
            Thread.Sleep(450);
            driver.FindElement(By.Id("plusButton")).Click();
            Thread.Sleep(450);
            driver.FindElement(By.Name("Huit")).Click();
            Thread.Sleep(450);
            driver.FindElement(By.Name("Est égal à")).Click();
            Thread.Sleep(450);

        }
    }
}
