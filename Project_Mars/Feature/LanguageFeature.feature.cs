﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Project_Mars.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LanguageFeature")]
    public partial class LanguageFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LanguageFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "LanguageFeature", "As a user I would be able to show what languages I know.\r\nSo that the people seek" +
                    "ing for languages can look at what details I hold.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 - Delete existing records")]
        [NUnit.Framework.CategoryAttribute("DELETE_EXISTING_RECORDS")]
        public void _01_DeleteExistingRecords()
        {
            string[] tagsOfScenario = new string[] {
                    "DELETE_EXISTING_RECORDS"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 - Delete existing records", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
       testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
       testRunner.When("User deletes existing records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
       testRunner.Then("language records deleted successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 - Add language record with valid details")]
        [NUnit.Framework.CategoryAttribute("ADD_LANGUAGES_VALID")]
        [NUnit.Framework.TestCaseAttribute("Urudu", "Basic", null)]
        public void _02_AddLanguageRecordWithValidDetails(string language, string level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ADD_LANGUAGES_VALID"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 - Add language record with valid details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
      testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
      testRunner.When(string.Format("Adding new \'{0}\' and \'{1}\' to the language list", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
      testRunner.Then(string.Format("New record with \'{0}\' and \'{1}\' are added successfully", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 - Add language record with invalid details")]
        [NUnit.Framework.CategoryAttribute("ADD_LANGUAGES_INVALID")]
        [NUnit.Framework.TestCaseAttribute("Tamil", "Choose Language Level", "Please enter language and level", null)]
        [NUnit.Framework.TestCaseAttribute("", "Fluent", "Please enter language and level", null)]
        [NUnit.Framework.TestCaseAttribute("", "Choose Language Level", "Please enter language and level", null)]
        [NUnit.Framework.TestCaseAttribute("Urudu", "Fluent", "Duplicated data", null)]
        [NUnit.Framework.TestCaseAttribute("Urudu", "Basic", "This language is already exist in your language list.", null)]
        [NUnit.Framework.TestCaseAttribute("@Malayalam#$%", "Conversational", "Special characters are not allowed", null)]
        [NUnit.Framework.TestCaseAttribute("Malayalam1234", "Conversational", "Numbers are not allowed", null)]
        [NUnit.Framework.TestCaseAttribute(@"Destructive software testing is a type of software testing which attempts to cause a piece of software to fail in an uncontrolled manner, in order to test its robustness and to help establish range limits, within which the software will operate in a stable and reliable manner", "Native/Bilingual", "The limit for the language field is 100 characters", null)]
        public void _03_AddLanguageRecordWithInvalidDetails(string language, string level, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ADD_LANGUAGES_INVALID"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("Message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 - Add language record with invalid details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
      testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
      testRunner.When(string.Format("Adding new \'{0}\' and \'{1}\' to the language list", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
   testRunner.Then(string.Format("The message \'{0}\' should be displayed", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 - Update existing language record with valid details")]
        [NUnit.Framework.CategoryAttribute("UPDATE_LANGUAGES")]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Fluent", null)]
        [NUnit.Framework.TestCaseAttribute("Kannada", "Native/Bilingual", null)]
        public void _04_UpdateExistingLanguageRecordWithValidDetails(string language, string level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UPDATE_LANGUAGES"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 - Update existing language record with valid details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 42
    testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 43
    testRunner.When(string.Format("Update \'{0}\' and \'{1}\' on an existing language record", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.Then(string.Format("The record should been updated \'{0}\' and \'{1}\' successfully", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 - Delete an existing language")]
        [NUnit.Framework.CategoryAttribute("DELETE_LANGUAGE")]
        [NUnit.Framework.TestCaseAttribute("Kannada", "Native/Bilingual", null)]
        public void _05_DeleteAnExistingLanguage(string language, string level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DELETE_LANGUAGE"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 - Delete an existing language", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 54
       testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
    testRunner.When(string.Format("User delete the \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
    testRunner.Then(string.Format("the record \'{0}\' should be deleted successfully", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 - Cancel the language when a recod is Update")]
        [NUnit.Framework.CategoryAttribute("CANCEL_LANGUAGE")]
        public void _06_CancelTheLanguageWhenARecodIsUpdate()
        {
            string[] tagsOfScenario = new string[] {
                    "CANCEL_LANGUAGE"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 - Cancel the language when a recod is Update", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 64
       testRunner.Given("User is logged into Project Mars and Navigate to language tab successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 65
    testRunner.When("click Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
    testRunner.Then("User clicked cancelled successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
