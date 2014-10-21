using System;
using TechTalk.SpecFlow;

namespace foo.specs
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        /*
        [Given(@"there is toothpaste on the brush")]
        public void GivenThereIsToothpasteOnTheBrush()
        {
            ScenarioContext.Current.Pending();
        }

         * */
        [Given(@"there is (.)* gram of toothpaste of (.)* on the brush")]
        public void GivenThereIsGramOfToothpasteOfBrandXOnTheBrush(int p0, string brand)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"there is (.)* gram of toothpaste on the brush")]
        public void GivenThereIsGramOfToothpasteOnTheBrush(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void Given_I_have_the_following_tools(Table table)
        {
            var firstToolName = table.Rows[0][0];
            var firstToolQuailty = table.Rows[0][1];

            var secondToolName = table.Rows[1]["ToolName"];
            var secondToolQuailty = table.Rows[1]["ToolQUality"];

            var isToolColorColumnSpecified = table.ContainsColumn("Color");

            ScenarioContext.Current.Pending();
        }


        [Given(@"the mouth is open")]
        public void GivenTheMouthIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the back teeth are  brushed")]
        public void WhenTheBackTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the front teeth are brushed")]
        public void WhenTheFrontTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the teeth look clean")]
        public void ThenTheTeethLookClean()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the mouth feels fresh")]
        public void ThenTheMouthFeelsFresh()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the braces aren't damaged")]
        public void ThenTheBracesArenTDamaged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
