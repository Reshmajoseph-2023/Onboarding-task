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
    public class LanguagePage : CommonDriver
    {
        
        private static IWebElement AddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddLanguageTextBox => driver.FindElement(By.Name("name"));
        private static IWebElement ChooseLanguageLevel => driver.FindElement(By.Name("level"));
        private static IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement newLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement newLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private static IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement UpdateLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement UpdateLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement UpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private static IWebElement updatedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static  IWebElement EditedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement deletedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement messageBox =>driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private static IWebElement  successMessage => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private static IWebElement LanguagesTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        private static IWebElement CancelButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
           
        //Deleting existing records before adding new records
        public void DeleteExistingRecords()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                while (true)
                {
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                                                                     
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
        //Adding New language to the language list
        public void AddLanguage(string language, string level)
        {

                //Click on AddNew button
                AddNew.Click();
                Thread.Sleep(1000);
                //Enter the language that needs to be added
                AddLanguageTextBox.SendKeys(language);
                //Choose the language level
                ChooseLanguageLevel.Click();
                ChooseLanguageLevel.SendKeys(level);
                //Click on Add button
                AddButton.Click();
                Thread.Sleep(3000);
                //get the text of the message element
                string actualMessage = messageBox.Text;
                Console.WriteLine(actualMessage);
                //verify the expected message text
                string expectedMessage1 = language + " has been added to your languages";
                string expectedMessage2 = "Please enter language and level";
                string expectedMessage3 = "Duplicated data";
                string expectedMessage4 = "This language is already exist in your language list.";
                Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
        }
         public string getLanguage()
         {
            Thread.Sleep(3000);
            return newLanguage.Text;
         }

         public string getLevel()
         {
            Thread.Sleep(3000);
            return newLevel.Text;
         }

         //Updating the language records
         public void EditLanguage(string language, string level)
         {
                //Click on pencilIcon
                PencilIcon.Click();
                //Edit the language
                UpdateLanguage.Clear();
                UpdateLanguage.SendKeys(language);
                //Choose the level 
                UpdateLevel.Click();
                Thread.Sleep(1000);
                UpdateLevel.SendKeys(level);
                //Click on Update button
                UpdateButton.Click();
                Thread.Sleep(2000);
                IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                Thread.Sleep(1000);
                //get the text of the message element
                string actualMessage = messageBox.Text;
                Console.WriteLine(actualMessage);
                //verify the expected message text
                string expectedMessage1 = language + " has been updated to your languages";
                string expectedMessage2 = "Please enter language and level";
                string expectedMessage3 = "Duplicated data";
                string expectedMessage4 = "This language is already added to your language list.";
                Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
         }
         public string getEditedLanguage()
         {
            Thread.Sleep(3000);
            return updatedLanguage.Text;
         }
         public string getEditedLevel()
         {
            Thread.Sleep(3000);
            return updatedLevel.Text;
         }

        //Delete a language record
        public void Delete_Language(string language)
        {     
              //Verify actual and expected language 
              if (EditedLanguage.Text == language)
              {
                Thread.Sleep(3000);
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                //Click on Delete button
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
        public string getDeletedLanguage()
        {
            Thread.Sleep(2000);
            return deletedLanguage.Text;
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
            //Click on language tab
            LanguagesTab.Click();
        }
    }
}
        

    


