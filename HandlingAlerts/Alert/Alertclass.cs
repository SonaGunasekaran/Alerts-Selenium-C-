/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HandlingAlerts.Alert
{
    public class Alertclass : Base.Baseclass
    {
        public static void TestAcceptAlert()
        {
            var expectedAlertText = "I am a JS Alert";
            //find the button element by using Css Selector
            driver.FindElement(By.CssSelector("button[onclick='jsAlert()']")).Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            //Accept the alert
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);
            //Check whether the expected and actual results are same or not
            Assert.AreEqual(expectedAlertText, alert_win.Text);

            //Find the result by Id
            IWebElement clickResult = driver.FindElement(By.Id("result"));
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (clickResult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
        }

        public static void TestConfirmAlert()
        {
            //find the button element by using Css Selector
            driver.FindElement(By.CssSelector("button[onclick='jsConfirm()']")).Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Accept the alert
            confirm_win.Accept();
            System.Threading.Thread.Sleep(2000);

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }

        public static void TestDismissAlert()
        {
            //Explicit wait-->Wait until the expected condition met
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //find the button element by using Css Selector
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[onclick='jsConfirm()']")));
            confirmButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Dismiss the alert
            confirm_win.Dismiss();
            System.Threading.Thread.Sleep(2000);

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }

        [Test, Order(4)]
        public static void TestSendalertText()
        {
            //Explicit wait-->Wait until the expected condition met
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //find the button element by using Css Selector
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[onclick='jsPrompt()']")));
            confirmButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("This is a test alert message");
            //Accept the alert
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (clickResult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}
