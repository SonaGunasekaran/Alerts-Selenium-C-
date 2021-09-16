/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using HandlingAlerts.DoAction;
using log4net;
using log4net.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace HandlingAlerts.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;
        public static ILog logger = LogManager.GetLogger(typeof(DoActions));
        [SetUp]
        public void Setup()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            //Launching chrome browser
            logger.Info("Launching browser");
            driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver.Url = "http://the-internet.herokuapp.com/javascript_alerts";
        }

        [TearDown]
        public void Close_Browser()
        {
            driver.Quit();
        }
    }
}
