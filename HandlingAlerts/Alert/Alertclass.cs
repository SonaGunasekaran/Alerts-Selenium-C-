/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HandlingAlerts.Alert
{
    public class Alertclass
    {
        public Alertclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement alertBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
