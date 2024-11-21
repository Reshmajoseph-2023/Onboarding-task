using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_Mars.Utilities;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class SkillsPage : CommonDriver
    {
        private static IWebElement SkillsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement AddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddSkillTextBox => driver.FindElement(By.Name("name"));
        private static IWebElement ChooseSkillLevel => driver.FindElement(By.Name("level"));
        private static IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement newSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement newSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private static IWebElement UpdateSkillsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement UpdateSkillTextBox => driver.FindElement(By.Name("name"));
        private static IWebElement UpdateSkillLevel => driver.FindElement(By.Name("level"));
        private static IWebElement UpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement updatedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement updatedSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement ElementToDelete => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement deletedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement deleteButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        private static IWebElement successMessage => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private static IWebElement  messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private static IWebElement CancelButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));

        //Deleting existing records before adding new records
        public void DeleteExistingRecords()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                while (true)
                {
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                    if (deleteButtons.Count == 0)
                    {
                        break;
                    }
                    foreach (var button in deleteButtons)
                    {
                        try
                        {
                            wait.Until(ExpectedConditions.ElementToBeClickable(button)).Click();
                            Thread.Sleep(5000);
                        }
                        catch (StaleElementReferenceException)
                        {
                            // Handle the exception by re-checking the element 
                        }
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No items to delete");
            }
        }

                
        //Adding New skill to the skill list
        public void AddSkills(string skill, string Level)
        {
            //Click on Skill tab
            SkillsTab.Click();
            Thread.Sleep(1000);
            //Click on AddNew button
            AddNew.Click();
            Thread.Sleep(1000);
            //Enter the skills that needs to be added
            AddSkillTextBox.SendKeys(skill);
            Thread.Sleep(1000);
            //Choose the skill level
            ChooseSkillLevel.Click();
            Thread.Sleep(1000);
            ChooseSkillLevel.SendKeys(Level);
            //Click onn Add button
            AddButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            
        }
        public string getSkill()
        {
            Thread.Sleep(5000);
            return newSkill.Text;
        }
        public string getSkillLevel()
        {
            Thread.Sleep(5000);
            return newSkillLevel.Text;
        }
        public string getMessage()
        {
            //Get the text message after entering skill and skill level
            Thread.Sleep(3000);
            return successMessage.Text;
        }

        //Updating the skill records
        public void EditSkills(string skill, string Level)
        {
            //Click on Skill tab
            UpdateSkillsTab.Click();
            Thread.Sleep(1000);
            //Click on Pencil Icon
            PencilIcon.Click();
            Thread.Sleep(1000);
            //Update the skill
            UpdateSkillTextBox.Clear();
            Thread.Sleep(1000);
            UpdateSkillTextBox.SendKeys(skill);
            Thread.Sleep(1000);
            //Choose the level from the drop down
            UpdateSkillLevel.Click();
            Thread.Sleep(1000);
            UpdateSkillLevel.SendKeys(Level);
            Thread.Sleep(1000);
            //Click on update button
            UpdateButton.Click();
            Thread.Sleep(2000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            
        }
        public string getUpdatedSkill()
        {
            Thread.Sleep(5000);
            return updatedSkill.Text;
        }
        public string getUpdatedSkillLevel()
        {
            Thread.Sleep(5000);
            return updatedSkillLevel.Text;
        }
        public string getActualMessage()
        {
            //Get the text message after updating language and language level

            return successMessage.Text;
        }
        //Delete a skill record
        public void Delete_Skill(string skill)
        {
            //Verify actual and expected skill
            if (ElementToDelete.Text == skill)
            {
                Thread.Sleep(3000);
                deleteButton.Click();
                Thread.Sleep(3000);
                //get the text of the message element
                string actualMessage = successMessage.Text;
                Console.WriteLine(actualMessage);
            }

            else
            {
                Console.WriteLine("Language to be deleted hasn't been found");
            }

        }
        public string getDeletedSkill()
        {
            Thread.Sleep(2000);
            return deletedSkill.Text;
        }
        //Cancel while a record is updating
        public void CancelFunction()
        {
            Thread.Sleep(5000);
            //Click on UpdateIcon
            PencilIcon.Click();
            Thread.Sleep(5000);
            //Click on Cancel button
            CancelButton.Click();
        }
        public void AssertionCancel()
        {
            Thread.Sleep(5000);
            //Click on skills tab
            SkillsTab.Click();
        }
    }
}