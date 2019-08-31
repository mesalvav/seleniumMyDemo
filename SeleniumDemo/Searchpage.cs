using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{   [TestClass]
    public class Searchpage
    {
        [TestMethod]
        public void SearchForMyPage()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            //  IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);

            // driver.Navigate().GoToUrl("https://cvdosforfiu.azurewebsites.net");
            driver.Navigate().GoToUrl("http://mywebappforfiu.azurewebsites.net");

            Console.WriteLine("=============>>>>>>> Test completed");
        }
    }
}
