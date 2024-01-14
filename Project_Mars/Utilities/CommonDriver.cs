using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            //Maximize the window
            driver.Manage().Window.Maximize();
        }
        public void Close()
        {
            driver.Close();
        }

    }
}