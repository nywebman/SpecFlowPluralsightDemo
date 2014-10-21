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


        [When]
        public void When_I_enter_a_password_of_PASSWORD(string password)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            p.Password = password;
        }

        [Then]
        public void Then_the_password_strength_indicator_should_read_STRENGTH(string strength)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            var actualStrength = p.PasswordStrength;

            Assert.AreEqual(strength, actualStrength);
        }


        [When]
        public void When_I_enter_valid_new_user_details()
        {
            string rndUserName = Guid.NewGuid().ToString().Substring(0, 10);
            var p = WebBrowser.Current.Page<RegistrationPage>();
            p.UserName = rndUserName;
            p.EmailAddress = "mrawesome@a.com";
            p.Password = "password";
            p.ConfirmPassword = "password";
        }

        [When]
        public void When_the_user_name_NAME_is_already_taken(string name)
        {
            TestData.CreateUser(name);
            var p = WebBrowser.Current.Page<RegistrationPage>();
            p.UserName = name;
        }

        [When]
        public void When_I_try_to_proceed_with_registration()
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            p.ClickRegisterButton();
        }

        [Then]
        public void Then_I_should_see_an_error_MESSAGE(string message)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();

            var isMessageDisplayed = p.ValidationErrorListText.Contains(message);

            Assert.IsTrue(isMessageDisplayed, message + " not found in validation errors");
        }
    }
}
