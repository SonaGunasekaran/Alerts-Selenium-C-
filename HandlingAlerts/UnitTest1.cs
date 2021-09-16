/*
 * Project:Handling Alerts using selenium
 * Author:Sona G
 * Date :14/09/2021
 */
using NUnit.Framework;

namespace HandlingAlerts
{
    public class Tests : Base.Baseclass
    {

        [Test, Order(1)]
        public void Test_alert()
        {
            DoAction.DoActions.TestAcceptAlert();
        }

        [Test, Order(2)]
        public void Test_confirm()
        {
            DoAction.DoActions.TestConfirmAlert();
        }

        [Test, Order(3)]
        public void Test_dismiss()
        {
            DoAction.DoActions.TestDismissAlert();
        }

        [Test, Order(4)]
        public void Test_sendalert_text()
        {
            DoAction.DoActions.TestSendAlertText();
        }
    }
}