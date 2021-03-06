/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HandlingAlerts.Prompt
{
    public class Promptclass
    {
        public Promptclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement promptBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
