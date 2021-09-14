/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HandlingAlerts.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://the-internet.herokuapp.com/javascript_alerts";
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
