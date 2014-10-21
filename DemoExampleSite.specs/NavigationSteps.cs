using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoExampleSite.specs
{
    [Binding]
    public class NavigationSteps
    {
        [Given]
        public void Given_I_m_on_the_registration_page()
        {
            //moved to a location for common steps
            WebBrowser.Current.GoTo("http://localhost:62988/Register.aspx");
        }
    }
}
