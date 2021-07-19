using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAllure.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Starting ");
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext sc)
        {
            Console.WriteLine("Finished");
            sc.quitDriver();
        }
    }
}
