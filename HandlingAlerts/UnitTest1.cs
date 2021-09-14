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
        public void test_alert()
        {
            Alert.Alertclass.TestAcceptAlert();
        }

        [Test, Order(2)]
        public void test_confirm()
        {
            Alert.Alertclass.TestConfirmAlert();

        }

        [Test, Order(3)]
        public void test_dismiss()
        {
            Alert.Alertclass.TestDismissAlert();
        }

        [Test, Order(4)]
        public void test_sendalert_text()
        {
            Alert.Alertclass.TestSendalertText();
        }
    }
}