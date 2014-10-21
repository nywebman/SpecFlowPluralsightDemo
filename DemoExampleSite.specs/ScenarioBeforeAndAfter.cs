﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoExampleSite.specs
{
    [Binding]
    internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void Before()
        {

        }

        [AfterScenario]
        public static void After()
        {
            WebBrowser.Current.Dispose();
        }
    }
}
