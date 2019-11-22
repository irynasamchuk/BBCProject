using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTestProject.PageObject
{
   public class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Get()
        {
            if (driver == null)
            {
                return driver = new ChromeDriver();
            }
            else
                return driver; 
        }

        public static void Close()
        {
            if (driver != null)
                driver.Quit();
        }


    }
}
