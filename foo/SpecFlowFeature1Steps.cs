using System;
using TechTalk.SpecFlow;

namespace foo
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"X")]
        public void GivenX()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Y")]
        public void WhenY()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Z")]
        public void ThenZ()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
