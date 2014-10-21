using System;
using TechTalk.SpecFlow;

namespace foo.specs
{
    [Binding]
    public class TeethWhitenessSteps
    {
        string _brand;

        [Given(@"I'm using ""(.*)"" brand toothpaste")]
        public void GivenIMUsingBrandToothpaste(string brand)
        {
            //add brand name from and save to context
            ScenarioContext.Current.Add("brand name", brand);
            _brand = brand;
        }
        
        [When(@"I brush for (.*) minutes")]
        public void WhenIBrushForMinutes(int p0)
        {
            //get the brand name from the context populated in the given
            var brandName = ScenarioContext.Current["brand name"];
        }
        
        [Then(@"the teeth look (.*) white")]
        public void ThenTheTeethLookWhite(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
