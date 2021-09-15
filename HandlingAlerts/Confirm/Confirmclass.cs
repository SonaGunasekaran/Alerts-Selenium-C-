/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HandlingAlerts.Confirm
{
    public class Confirmclass
    {
        public Confirmclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement confirmBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
