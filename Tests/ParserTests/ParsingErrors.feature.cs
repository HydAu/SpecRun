// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.3.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ParserTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Providing meaningful errors for wrong Gherkin files")]
    public partial class ProvidingMeaningfulErrorsForWrongGherkinFilesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ParsingErrors.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Providing meaningful errors for wrong Gherkin files", "In order to find out easily what is wrong with a Gherkin file\r\nAs a SpecFlow user" +
                    "\r\nI want to get proper error messages when the files are parsed", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wrongly spelled feature keyword")]
        public virtual void WronglySpelledFeatureKeyword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wrongly spelled feature keyword", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
testRunner.Given("there is a Gherkin file as", "\tFeaturX: wrong feature", ((TechTalk.SpecFlow.Table)(null)));
#line 11
testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table1.AddRow(new string[] {
                        "1",
                        "FeaturX"});
#line 12
testRunner.Then("the the following errors are provided", ((string)(null)), table1);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wrongly spelled step keyword")]
        public virtual void WronglySpelledStepKeyword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wrongly spelled step keyword", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 17
testRunner.Given("there is a Gherkin file as", "\tFeature: misspelled step keyword\r\n\r\n\tScenario: misspelled step keyword\r\n\t\tGiven " +
                    "something\r\n\t\tWhenX something is misspelled", ((TechTalk.SpecFlow.Table)(null)));
#line 25
testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table2.AddRow(new string[] {
                        "5",
                        "WhenX"});
#line 26
testRunner.Then("the the following errors are provided", ((string)(null)), table2);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Restart parsing after a syntax error")]
        public virtual void RestartParsingAfterASyntaxError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Restart parsing after a syntax error", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 31
testRunner.Given("there is a Gherkin file as", "\tFeature: misspelled step keyword\r\n\r\n\tScenario: misspelled step keyword 1\r\n\t\tGive" +
                    "n something\r\n\t\tWhenX something is misspelled\r\n\t\tThenX something is also misspell" +
                    "ed", ((TechTalk.SpecFlow.Table)(null)));
#line 40
testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table3.AddRow(new string[] {
                        "5",
                        "WhenX"});
            table3.AddRow(new string[] {
                        "6",
                        "ThenX"});
#line 41
testRunner.Then("the the following errors are provided", ((string)(null)), table3);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Table cell count mismatch")]
        public virtual void TableCellCountMismatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Table cell count mismatch", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 47
testRunner.Given("there is a Gherkin file as", "\tFeature: Table cell count mismatch\r\n\r\n\tScenario: Table cell count mismatch\r\n\t\tGi" +
                    "ven a table\r\n\t\t\t| h1 | h2 |\r\n\t\t\t| c1 | c2 | c3 |", ((TechTalk.SpecFlow.Table)(null)));
#line 56
testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table4.AddRow(new string[] {
                        "6",
                        "Number of cells in the row does not match the number of cells in the header!"});
#line 57
testRunner.Then("the the following errors are provided", ((string)(null)), table4);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Restart parsing after a semantic error")]
        public virtual void RestartParsingAfterASemanticError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Restart parsing after a semantic error", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 62
testRunner.Given("there is a Gherkin file as", "\tFeature: Table cell count mismatch\r\n\r\n\tScenario: Table cell count mismatch\r\n\t\tGi" +
                    "ven a table\r\n\t\t\t| h1 | h2 |\r\n\t\t\t| c1 | c2 | c3 |\r\n\t\t\t| c1 | c2 | c3 |", ((TechTalk.SpecFlow.Table)(null)));
#line 72
testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table5.AddRow(new string[] {
                        "6",
                        "Number of cells in the row does not match the number of cells in the header!"});
            table5.AddRow(new string[] {
                        "7",
                        "Number of cells in the row does not match the number of cells in the header!"});
#line 73
testRunner.Then("the the following errors are provided", ((string)(null)), table5);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
