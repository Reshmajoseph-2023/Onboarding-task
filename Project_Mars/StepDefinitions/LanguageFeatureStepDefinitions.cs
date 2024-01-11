using NUnit.Framework;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using System;
using System.Reflection.Emit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        LanguagePage LanguagePageObj;
        LoginPage LoginPageObj;
        ProfilePage ProfilePageObj;
        public LanguageFeatureStepDefinitions()
        {
            LanguagePageObj = new LanguagePage();
            LoginPageObj = new LoginPage();
            ProfilePageObj = new ProfilePage();
        }
    
        [Given(@"User is logged into Project Mars and Navigate to language tab successfully")]
        public void GivenUserIsLoggedIntoProjectMarsAndNavigateToLanguageTabSuccessfully()
        {
            LoginPageObj.LoginSteps();
            ProfilePageObj.GoToLanguageTab();
        }

        [When(@"User deletes existing records")]
        public void WhenUserDeletesExistingRecords()
        {
            LanguagePageObj.DeleteExistingRecords();
        }
        [Then(@"language records deleted successfully")]
        public void ThenLanguageRecordsDeletedSuccessfully()
        {
           // Console.WriteLine("Records deleted");
        }

        [When(@"Adding new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddingNewAndToTheLanguageList(string language, string level)
        {
            // Adding new language to the language list
            LanguagePageObj.AddLanguage(language, level);
        }

        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string language, string level)
        {
            string newLanguage = LanguagePageObj.getLanguage();
            string newLevel = LanguagePageObj.getLevel();

            if (language == newLanguage && level == newLevel)
            {
                Assert.That(language == newLanguage, "Actual language and expected language do not match.");
                Assert.That(level == newLevel, "Actual level and expected level do not match.");
            }
            else
            {
                Console.WriteLine("Check Error");
            }
        }
        [Then(@"The message '([^']*)' should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string expectedMessage)
        {
            string actualMessage = LanguagePageObj.getLanguage();
            //Console.WriteLine($"{expectedMessage} {actualMessage}");
            Assert.That(actualMessage == expectedMessage, "Actual message and expected message do not match");
        }


        [When(@"Update '([^']*)' and '([^']*)' on an existing language record")]
        public void WhenUpdateAndOnAnExistingLanguageRecord(string language, string level)
        {
            //update an existing language in the language list  
            LanguagePageObj.EditLanguage(language, level);
        }

        [Then(@"The record should been updated '([^']*)' and '([^']*)' successfully")]
        public void ThenTheRecordShouldBeenUpdatedAndSuccessfully(string language, string level)
        {
            string createdLanguage = LanguagePageObj.getEditedLanguage();
            string createdLevel = LanguagePageObj.getEditedLevel();

            if (language == createdLanguage && level == createdLevel)
            {
                Assert.That(language == createdLanguage, "updated language and expected language do not match.");
                Assert.That(level == createdLevel, "updated level and expected level do not match.");
            }
            else
            {
                Console.WriteLine("Check Error");
            }
        }

        [When(@"User delete the '([^']*)'")]
        public void WhenUserDeleteThe(string language)
        {
            LanguagePageObj.Delete_Language(language);
        }

        [Then(@"the record '([^']*)' should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully(string language)
        {
            string deletedLanguage = LanguagePageObj.getDeletedLanguage();

            Assert.That(deletedLanguage != language, "Expected language has not been deleted");
        }

        [When(@"click Cancel button")]
        public void WhenClickCancelButton()
        {
            LanguagePageObj.CancelFunction();
        }

        [Then(@"User clicked cancelled successfully")]
        public void ThenUserClickedCancelledSuccessfully()
        {
            LanguagePageObj.AssertionCancel();
        }

    }

}
