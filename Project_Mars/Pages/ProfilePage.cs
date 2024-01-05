using OpenQA.Selenium;
using Project_Mars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class ProfilePage : CommonDriver
    {
        public void GoToLanguageTab()
        {
            //Clicking on Language tab button in the profile page
            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageTab.Click();
            Thread.Sleep(1000);
        }
        public void GoToSkillTab()
        {
            //Clicking on Language tab button in the profile page
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            Thread.Sleep(1000);
        }
    }
}