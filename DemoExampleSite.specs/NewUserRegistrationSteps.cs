﻿using System;
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
    }
}
