using System;
using TechTalk.SpecFlow;
using WatiN.Core;
using DemoExampleSite.specs.DemoHelpers;
using NUnit.Framework;

namespace DemoExampleSite.specs
{
    [Binding]
    public class NewUserRegistrationSteps
    {
        [Given]
        public void Given_I_m_on_the_registration_page()
        {
            WebBrowser.Current.GoTo("http://localhost:62988/Register.aspx");
        }

        [When]
        public void When_I_enter_a_password_of_PASSWORD(string password)
        {
            WebBrowser.Current.TextField(Find.ById("Password")).TypeText(password);
            //  WebBrowser.Current.Eval("$('#Password').keypress()");//to get around a watin bug bcse the js keypress doesnt always fire
        }

        [Then]
        public void Then_the_password_strength_indicator_should_read_STRENGTH(string strength)
        {
            var actualStrength = WebBrowser.Current.Div(Find.ById("PasswordStrength")).InnerHtml;

            Assert.AreEqual(strength, actualStrength);
        }


        [When]
        public void When_I_enter_valid_new_user_details()
        {
            string rndUserName = Guid.NewGuid().ToString().Substring(0, 10);
            WebBrowser.Current.TextField(Find.ById("UserName")).TypeText(rndUserName);
            WebBrowser.Current.TextField(Find.ById("EmailAddress")).TypeText("mrawesome@a.com");
            WebBrowser.Current.TextField(Find.ById("Password")).TypeText("password");
            WebBrowser.Current.TextField(Find.ById("ConfirmPassword")).TypeText("password");
        }

        [When]
        public void When_the_user_name_NAME_is_already_taken(string name)
        {
            TestData.CreateUser(name);
            WebBrowser.Current.TextField(Find.ById("UserName")).TypeText(name);
        }

        [When]
        public void When_I_try_to_proceed_with_registration()
        {
            WebBrowser.Current.Button(Find.ById("DoRegister")).Click();
        }

        [Then]
        public void Then_I_should_see_an_error_MESSAGE(string message)
        {
            var isMessageDisplayed = WebBrowser.Current
                .List(Find.ById("ValidationErrorList"))
                .Text.Contains(message);

            Assert.IsTrue(isMessageDisplayed, message + " not found in validation errors");
        }
    }
}
