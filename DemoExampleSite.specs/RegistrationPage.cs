using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace DemoExampleSite.specs
{
    /*
     to model the aspx/html/... page in case control names change
     * so only need to reference the const here for controls, and only
     * one place to change if the control name changes
     */

    //inherit from watin page class
    internal class RegistrationPage : Page
    {
        private const string UserNameId = "UserName";
        private const string EmailAddressId = "EmailAddress";
        private const string PasswordId = "Password";
        private const string ConfirmPasswordId = "ConfirmPassword";
        private const string PasswordStrengthId = "PasswordStrength";
        private const string ValidationErrorListId = "validationErrorList";
        private const string DoRegisterId = "DoRegister";

        public string UserName
        {
            get
            {
                return this.Document.TextField(Find.ById(UserNameId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(UserNameId)).TypeText(value);
            }
        }
        public string EmailAddress
        {
            get
            {
                return this.Document.TextField(Find.ById(EmailAddressId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(EmailAddressId)).TypeText(value);
            }
        }
        public string Password
        {
            get
            {
                return this.Document.TextField(Find.ById(PasswordId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(PasswordId)).TypeText(value);
                //WatiN typeText - the js keypress event doesnt fire
                //WebBrowser.Current.Eval(string.Format("$('#{0}').keyPress()",Password));
            }
        }
        public string ConfirmPassword
        {
            get
            {
                return this.Document.TextField(Find.ById(ConfirmPasswordId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(ConfirmPasswordId)).TypeText(value);
            }
        }
        public string PasswordStrength
        {
            get
            {
                return this.Document.Div(Find.ById(PasswordStrengthId)).InnerHtml;
            }
        }
        public string ValidationErrorListText
        {
            get
            {
                return this.Document.List(Find.ById(ValidationErrorListId)).Text;
            }
        }

        public void ClickRegisterButton()
        {
            Document.Button(Find.ById(DoRegisterId)).Click();
        }
    }
}
