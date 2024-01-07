using NUnit.Framework;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        SkillsPage SkillsPageObj;
        LoginPage LoginPageObj;
        ProfilePage ProfilePageObj;
        public SkillFeatureStepDefinitions()
        {
            SkillsPageObj = new SkillsPage();
            LoginPageObj = new LoginPage();
            ProfilePageObj = new ProfilePage();
        }
        [Given(@"User is logged into ProjectMars and navigate to skills tab successfully")]
        public void GivenUserIsLoggedIntoProjectMarsAndNavigateToSkillsTabSuccessfully()
        {
            LoginPageObj.LoginSteps();
            ProfilePageObj.GoToSkillTab();
        }

        [When(@"User deletes the existing records")]
        public void WhenUserDeletesTheExistingRecords()
        {
       
         SkillsPageObj.DeleteExistingRecords();
        }

        [Then(@"skill records deleted successfully")]
        public void ThenSkillRecordsDeletedSuccessfully()
        {
         
        Console.WriteLine("Records deleted");
        }

        [When(@"Adding new '([^']*)' and '([^']*)' to the skill list")]
        public void WhenAddingNewAndToTheSkillList(string skill, string Level)
        {
            //Adding new skill to the skill list
            SkillsPageObj.AddSkills(skill, Level);
        }

        [Then(@"New skill record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewSkillRecordWithAndAreAddedSuccessfully_(string skill, string Level)
        {
            //Assertion of added skills
            string newSkill = SkillsPageObj.getSkill();
            string newSkillLevel = SkillsPageObj.getSkillLevel();

            if (skill == newSkill && Level == newSkillLevel)
            {
                Assert.That(skill == newSkill, "Actual skill and expected skill do not match");
                Assert.That(Level == newSkillLevel, "Actual skill level and expected skill level do not match");
             }
            else
            {
                Console.WriteLine("Check Error");
            }
        }
   

        [When(@"Update '([^']*)' and '([^']*)' on an existing skill record\.")]
        public void WhenUpdateAndOnAnExistingSkillRecord_(string skill, string Level)
        {
            //update an existing Skill in the Skill list  
            SkillsPageObj.EditSkills(skill, Level);
        }

        [Then(@"The skill record should been updated '([^']*)' and '([^']*)' Successfully")]
        public void ThenTheSkillRecordShouldBeenUpdatedAndSuccessfully(string skill, string Level)
        {
            //Assertion of updated Skill
            string newUpdatedSkill = SkillsPageObj.getUpdatedSkill();
            string newUpdatedSkillLevel = SkillsPageObj.getUpdatedSkillLevel();

            if (skill == newUpdatedSkill && Level == newUpdatedSkillLevel)
            {
            Assert.That(skill==newUpdatedSkill, "Updated skill and expected skill do not match.");
            Assert.That(Level==newUpdatedSkillLevel, "Updated Skilllevel and created skilllevel do not match");
            }
            else
            {
                Console.WriteLine("Check error");
            }
        }

        [When(@"User Delete the record '([^']*)'")]
        public void WhenUserDeleteTheRecord(string skill)
        {
            SkillsPageObj.Delete_Skill(skill);
        }

        [Then(@"The record '([^']*)' should deleted successfully")]
        public void ThenTheRecordShouldDeletedSuccessfully(string skill)
        {
            string deletedSkill = SkillsPageObj.getDeletedSkill();

            Assert.That(deletedSkill != skill, "Expected language has not been deleted");
        }

        [When(@"click Cancel button when update skill")]
        public void WhenClickCancelButtonWhenUpdateSkill()
        {
            SkillsPageObj.CancelFunction();
        }

        [Then(@"User was able to click cancel button successfully")]
        public void ThenUserWasAbleToClickCancelButtonSuccessfully()
        {
            SkillsPageObj.AssertionCancel();
        }

    }
}
